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



namespace WindowsFormsApp1
{
    [Serializable]
    public partial class altavoz : Form
    {
        HashSet<Cancion> album = new HashSet<Cancion>();
        List<String> paEliminar = new List<String>();
        public altavoz()
        {
            InitializeComponent();
            milistBox.SelectedIndexChanged += seleccion;
            this.BackgroundImage = Image.FromFile(Path.Combine(Application.StartupPath,"fondo.png"));
            button1.FlatStyle = FlatStyle.Flat;
            button1.FlatAppearance.BorderSize = 0;
            button1.BackColor = Color.Transparent;
            button1.FlatAppearance.MouseOverBackColor = Color.Transparent;
            button1.FlatAppearance.MouseDownBackColor = Color.Transparent;
            button1.MouseEnter += Button1_MouseEnter;
            button1.MouseLeave += Button1_MouseLeave;
            this.FormClosing += Form1_FormClosing;

        }
        private void Button1_MouseEnter(object sender, EventArgs e)
        {
            
            button1.Cursor = Cursors.Hand;
            button1.BackColor = Color.FromArgb(50, Color.Gray);

        }

        private void Button1_MouseLeave(object sender, EventArgs e)
        {
            
            button1.Cursor = Cursors.Default;
            button1.BackColor = Color.Transparent;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            if(milistBox.Items.Count == 0)
            {
                MessageBox.Show("No hay elementos para guardar", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databank.data");
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Create);
            BinaryFormatter formato = new BinaryFormatter();
            formato.Serialize(archivo, album);
            archivo.Close();
        }


        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {

            foreach(String tema in paEliminar)
            {
                File.Delete(tema);
            }
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databank.data"); 
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Append);
            BinaryFormatter formato = new BinaryFormatter();
            formato.Serialize(archivo, album);
            archivo.Close();
 
        }

        private void seleccion(object sender, EventArgs e)
        {
            int index = milistBox.SelectedIndex;
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
            Form2 rellena = new Form2();
            // Mostrar el nuevo formulario
            if (rellena.ShowDialog() == DialogResult.OK)
            {
                album.Add(rellena.Actual);
                milistBox.Items.Add(rellena.Actual.Titulo + " | " + rellena.Actual.Autor);
                milistBox.Refresh();
                MessageBox.Show("Se ha guardado la cancion correctamente", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                
                
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
        static Image redimensionarImagen(Image imagenOriginal, int nuevoAncho, int nuevoAlto)
        {
            Bitmap nuevaImagen = new Bitmap(nuevoAncho, nuevoAlto);
            using (Graphics graphics = Graphics.FromImage(nuevaImagen))
            {
                graphics.InterpolationMode = System.Drawing.Drawing2D.InterpolationMode.HighQualityBicubic;
                graphics.DrawImage(imagenOriginal, 0, 0, nuevoAncho, nuevoAlto);
            }

            return nuevaImagen;
        }

        private void eliminarbutton_Click(object sender, EventArgs e)
        {
            int index = milistBox.SelectedIndex;
            Cancion[] aux = album.ToArray();
            album.Remove(aux[index]);
            milistBox.Items.RemoveAt(index);
            milistBox.ClearSelected();
            seleccion(milistBox, EventArgs.Empty);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            int index = milistBox.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("No hay ninguna cancion seleccionada", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            try
            {
                Cancion[] aux = album.ToArray();
                MemoryStream temita = new MemoryStream(aux[index].Audio);
                string rutaTemporal = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, aux[index].Titulo + ".mp3");
                // Guardar el contenido del MemoryStream en el archivo temporal
                File.WriteAllBytes(rutaTemporal, temita.ToArray());
                ConvertirAMp3(temita, rutaTemporal);
                paEliminar.Add(rutaTemporal);
                temita.Close();
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

        private void cargarButton_Click(object sender, EventArgs e)
        {
            string rutaArchivo = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "databank.data");
            FileStream archivo = new FileStream(rutaArchivo, FileMode.Open);
            BinaryFormatter formato = new BinaryFormatter();
            HashSet<Cancion> datos = (HashSet<Cancion>)formato.Deserialize(archivo);
            foreach (Cancion tema in datos)
            {
                album.Add(tema);
                milistBox.Items.Add(tema.Titulo + " | " + tema.Autor);
            }
            archivo.Close();
        }
    }
}
