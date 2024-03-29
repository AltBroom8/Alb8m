﻿using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form2 : Form
        
    {
        //Cancion que recibe el otro form
        private Cancion actual = new Cancion();
        //Booleano para saber si se cierra bien el programa
        private Boolean exito = false;
        public Cancion Actual
        {
            get { return actual; }
            set { actual = value; }
        }
        public Boolean Exito
        {
            get { return exito; }
            set { exito = value; }
        }

        public Form2()
        {
            InitializeComponent();
            this.Icon = new Icon("LOGO_1.ico");
            this.Text = "Nueva cancion";
            // Configura dos ComboBox para permitir solo selecciones de la lista desplegable
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
            //No se puede escribir en los textbox de la portada y el audio.
            portadaTextbox.ReadOnly = true;
            portadaTextbox.Enabled = false;
            audiotextBox.ReadOnly = true;
            audiotextBox.Enabled = false;
            //Ajusta donde se coloca el cursor
            maskedTextBox1.MouseClick += maskedTextBox1_MouseClick;
            this.FormClosing += Form1_FormClosing;

        }

        
        //Boton para adjuntar ruta de imagen
        private void buscarButton_Click(object sender, EventArgs e)
        {
            //Archivos permitidos
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de imagen|*.jpg;*.jpeg;*.png;*.gif;*.bmp|Todos los archivos|*.*";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                portadaTextbox.Text = openFileDialog.FileName;
            }
        }
        //Boton para adjuntar ruta de audio
        private void audiobutton_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Archivos de audio|*.mp3;*.wav;*.ogg;*.flac";

            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                // Obtener la ruta del archivo seleccionado
                audiotextBox.Text = openFileDialog.FileName;
            }
        }
        //Cierre de programa
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            //Si fuerzas el cierre hay un aviso
            if (exito == false)
            {
                DialogResult result = MessageBox.Show("¿Estás seguro de que quieres salir? No se guardaran los datos.", "Salir", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.No)
                {
                    e.Cancel = true; // Cancela el cierre del formulario si el usuario elige "No"
                }
            }
        }
        //Encuetra el primer espacio libre para escribir y situa el cursor ahi
        private void maskedTextBox1_MouseClick(object sender, MouseEventArgs e)
        {
            int index = FindFirstEmptySpace(maskedTextBox1.Text);
            maskedTextBox1.SelectionStart = index;
        }

        private int FindFirstEmptySpace(string text)
        {
            for (int i = 0; i < text.Length; i++)
            {
                if (text[i] == ' ')
                {
                    return i;
                }
            }
            return text.Length; // Si no se encuentra un espacio vacío, devuelve la longitud total del texto.
        }
        //Checkeo de que los campos se rellenan correctamente.
        private void aceptarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tituloTextbox.Text))
            {
                MessageBox.Show("¿¿Como me vas a dejar el titulo vacio alma de cántaro??", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(autorTextbox.Text))
            {
                MessageBox.Show("Estaría bien saber quien hizo la cancion...", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(comboBox1.Text)){
                MessageBox.Show("Estaría bien saber el genero: ¿Salsa o reggaeton?", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(maskedTextBox1.Text))
            {
                MessageBox.Show("Necesito saber los BPM. Gotta go fast!!!", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(comboBox2.Text))
            {
                MessageBox.Show("Si no me dices el tono, los productores no podran ajustar el Autotune.", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(portadaTextbox.Text)){
                MessageBox.Show("Para continuar, debes elegir la portada de la cancion", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }else if (string.IsNullOrEmpty(audiotextBox.Text)){
                MessageBox.Show("Elige tu cancion, espero que sea el Mambo de KIKO RIVERA", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            //Si todo esta correcto, incluye los datos en la instancia, y levanta la bandera.
            else
            {
                actual.Titulo = tituloTextbox.Text;
                actual.Autor = autorTextbox.Text;
                actual.Fecha = dateTimePicker1.Value;
                actual.Genero = comboBox1.Text;
                actual.BPM = int.Parse(maskedTextBox1.Text);
                actual.Key = comboBox2.Text;
                actual.Portada = Image.FromFile(portadaTextbox.Text);
                actual.Audio = File.ReadAllBytes(audiotextBox.Text);
                exito = true;
                DialogResult = DialogResult.OK;
                Close();
            }
        }
    }

}
