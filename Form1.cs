using System;
using System.IO;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using NAudio.Wave;
using System.Reflection;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization;
using System.Drawing.Imaging;



namespace WindowsFormsApp1
{
    public partial class altavoz : Form
    {
        //Hashset y lista que almacena las canciones en el sistema
        HashSet<Cancion> album = new HashSet<Cancion>();
        List<String> paEliminar = new List<String>();
        public altavoz()
        {
            //inicializa los componentes
            InitializeComponent();
            //metodo en caso de que cambie el selector
            milistBox.SelectedIndexChanged += seleccion;
            //fondo, icono y titulo :)
            this.Text = "Alb8m";
            this.Icon = new Icon("LOGO_1.ico");
            this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath,"fondo.png"));
            //Estilos del boton altavoz
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            this.FormClosing += Form1_FormClosing;

        }
        //Esto es un hover 
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            
            button1.Cursor = Cursors.Hand;
            button1.BackColor = Color.FromArgb(50, Color.Gray);

        }
        //Esto es para cuando el mouse sale del raton
        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            
            button1.Cursor = Cursors.Default;
            button1.BackColor = Color.Transparent;
        }
        //Boton guardar
        private void button1_Click(object sender, EventArgs e)
        {
            metodoGuarda();
        }
        //Metodo para guardar la lista, lo hago en un metodo aparte porque se vuelve a pedir al cerrar el programa.
        private void metodoGuarda()
        {
            //En caso que la lista este vacia no guarda
            if (milistBox.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos para guardar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            //Crea el archivo y el writer
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databank.data");
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Create);
            BinaryWriter bin = new BinaryWriter(archivo);
            foreach (Cancion temita in album)
            {
                //Escribe atributos
                bin.Write(temita.Titulo);
                bin.Write(temita.Autor);
                //La fecha hay que pasarla a binario
                bin.Write(temita.Fecha.ToBinary());
                bin.Write(temita.Genero);
                bin.Write(temita.BPM);
                bin.Write(temita.Key);
                //La imagen la tienes que guardar en un array, y para eso antes la convierto a png
                MemoryStream ms = new MemoryStream();
                temita.Portada.Save(ms, ImageFormat.Png);
                byte[] imagen = ms.ToArray();
                //Guardamos la imagen y el audio.
                bin.Write(imagen.Length);
                bin.Write(imagen);
                bin.Write(temita.Audio.Length);
                bin.Write(temita.Audio);
            }
            //Cerramos 
            bin.Close();
            archivo.Close();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Elimina los archivos creados
            foreach(String tema in paEliminar)
            {
                File.Delete(tema);
            }
            //Guarda la lista
            metodoGuarda();
 
        }

        private void seleccion(object sender, EventArgs e)
        {
            int index = milistBox.SelectedIndex;
            //Si no hay nada seleccionado vacia los campos
            if (index == -1)
            {
                titulodef.Text = "";
                autordef.Text = "";
                fechadef.Text = "";
                generodef.Text = "";
                bpmdef.Text = "";
                keydef.Text = "";
                actualImagen.Image = null;

            }
            //Si hay algo seleccionado rellena los campos
            else
            {
                Cancion[] aux = album.ToArray();
                titulodef.Text = aux[index].Titulo;
                autordef.Text = aux[index].Autor;
                fechadef.Text = aux[index].Fecha.ToString("dddd dd 'de' MMMM 'de' yyyy");
                generodef.Text = aux[index].Genero;
                bpmdef.Text = aux[index].BPM.ToString();
                keydef.Text = aux[index].Key;
                aux[index].Portada = redimensionarImagen(aux[index].Portada,actualImagen.Width,actualImagen.Height);
                actualImagen.Image = aux[index].Portada;

            }

        }

        private void button2_Click(object sender, EventArgs e)
        {
            // Mostrar el nuevo formulario
            Form2 rellena = new Form2();
            //Comprueba que el formulario se cerro correctamente y actualiza la lista
            if (rellena.ShowDialog() == DialogResult.OK)
            {
                album.Add(rellena.Actual);
                milistBox.Items.Add(rellena.Actual.Titulo + " | " + rellena.Actual.Autor);
                milistBox.Refresh();
                MessageBox.Show("Se ha guardado la cancion correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                
            }
        }
        //Metodo para redimensionar una imagen en el cuadro solicitado
        static Image redimensionarImagen(Image imagenOriginal, int nuevoAncho, int nuevoAlto)
        {
            //Bitmap con ancho y alto
            Bitmap nuevaImagen = new Bitmap(nuevoAncho, nuevoAlto);
            // Utilizando la clase Graphics dibujar una imagen (nuevaImagen)
            using (Graphics graphics = Graphics.FromImage(nuevaImagen))
            {
                //Mejora la calidad de redimension segun el modo de interpolacion
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                //Dibuja
                graphics.DrawImage(imagenOriginal, 0, 0, nuevoAncho, nuevoAlto);
            }

            return nuevaImagen;
        }
        //Boton eliminar
        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            //Si la lista esta vacia no se puede eliminar
            if (milistBox.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos para eliminar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//Si no hay una cancion seleccionada no se puede eliminar
            else if(milistBox.SelectedIndex == -1)
            {
                MessageBox.Show("Debes elegir un elemento para eliminarlo", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//En otro caso se elimina del hashset y de la lista
            else
            {
                int index = milistBox.SelectedIndex;
                Cancion[] aux = album.ToArray();
                album.Remove(aux[index]);
                milistBox.Items.RemoveAt(index);
                milistBox.ClearSelected();
                seleccion(milistBox, EventArgs.Empty);
            }
            

        }
        //Metodo para el boton del altavoz
        private void button1_Click_1(object sender, EventArgs e)
        {
            //Si no hay ninguna cancion seleccionada no suena nada
            int index = milistBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("No hay ninguna cancion seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }//En otro caso
            try
            {
                //Pasamos el hashset a array para saber en que cancion estamos
                Cancion[] aux = album.ToArray();
                MemoryStream temita = new MemoryStream(aux[index].Audio);
                //Damos ruta al futuro mp3
                string rutaTemporal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, aux[index].Titulo + ".mp3");
                // Guardar el contenido del MemoryStream en el archivo temporal
                File.WriteAllBytes(rutaTemporal, temita.ToArray());
                ConvertirAMp3(temita, rutaTemporal);
                //Añadimos a la lista
                paEliminar.Add(rutaTemporal);
                temita.Close();
                //Lo abrimos en el reproductor(En otro hilo para poder seguir usando la app)
                Task.Run(() => AbrirReproductorPredeterminado(rutaTemporal));
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
            }

        }
        static void ConvertirAMp3(MemoryStream input, string rutaDestino)
        {
            try
            {
                // Crear un archivo temporal WAV
                string rutaTemporalWav = Path.ChangeExtension(Path.GetTempFileName(), "wav");

                // Escribir el contenido del MemoryStream en el archivo temporal WAV
                File.WriteAllBytes(rutaTemporalWav, input.ToArray());

                // Convertir el archivo WAV a MP3
                using (var reader = new WaveFileReader(rutaTemporalWav))
                {
                    WaveFileWriter.CreateWaveFile(rutaDestino, reader);
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir a MP3: " + ex.Message);
            }
        }
        static void AbrirReproductorPredeterminado(string rutaArchivo)
        {
            try
            {
                //Abre el proceso,ruta,como se inicia y si genera mas eventos. Luego se inicia.
                Process procesoReproductor = new Process();
                procesoReproductor.StartInfo.FileName = rutaArchivo;
                procesoReproductor.StartInfo.UseShellExecute = true;
                procesoReproductor.EnableRaisingEvents = true;
                procesoReproductor.Start();
                
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al abrir el reproductor de medios: " + ex.Message);
            }
        }
        //Boton cargar
        private void cargarButton_Click(object sender, EventArgs e)
        {
           
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databank.data");
            //Si existe la ruta
            if (File.Exists(rutaArchivo)) { 
                //Archivo y reader
                FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);
                BinaryReader br = new BinaryReader(archivo);
                while(br.BaseStream.Position < br.BaseStream.Length)
                {
                    //Leemos los campos
                    Cancion cancion = new Cancion();
                    cancion.Titulo = br.ReadString();
                    cancion.Autor = br.ReadString();
                    //Conversion de binario a fecha
                    cancion.Fecha = DateTime.FromBinary(br.ReadInt64());
                    cancion.Genero = br.ReadString();
                    cancion.BPM = br.ReadInt32();
                    cancion.Key = br.ReadString();
                    int imagenLength = br.ReadInt32();
                    //Lectura de la imagen
                    byte[] imagenBytes = br.ReadBytes(imagenLength);
                    MemoryStream ms = new MemoryStream(imagenBytes);
                    //Asigno imagen
                    cancion.Portada = Image.FromStream(ms);
                    int audioLength = br.ReadInt32();
                    cancion.Audio = br.ReadBytes(audioLength);
                    //Añadimos la cancion al album y la lista
                    album.Add(cancion);
                    milistBox.Items.Add(cancion.Titulo + " | " + cancion.Autor); ;

                }
                //Cerramos
                br.Close();
                archivo.Close();
            }
            else
            {
                MessageBox.Show("No hay ningun archivo para cargar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }
}
