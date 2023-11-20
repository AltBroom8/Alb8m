using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
[Serializable]
public class Cancion
{
   
    // Atributos privados de la canción
    private string titulo;
    private string autor;
    private DateTime fecha;
    private string genero;
    private int bpm;
    private string key;
    private Image portada;
    private byte[] audio;

    // Propiedades públicas con getters y setters
    public string Titulo
    {
        get { return titulo; }
        set { titulo = value; }
    }
    public byte[] Audio
    {
        get { return audio; }
        set { audio = value; }
    }
    public string Autor
    {
        get { return autor; }
        set { autor = value; }
    }

    public DateTime Fecha
    {
        get { return fecha; }
        set { fecha = value; }
    }

    public string Genero
    {
        get { return genero; }
        set { genero = value; }
    }

    public int BPM
    {
        get { return bpm; }
        set { bpm = value; }
    }

    public string Key
    {
        get { return key; }
        set { key = value; }
    }

    public Image Portada
    {
        get { return portada; }
        set { portada = value; }
    }
}