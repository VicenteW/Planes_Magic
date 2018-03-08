using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;
using System.IO;

namespace Planos_Magic2
{
    public partial class Form1 : Form
    {
        string[,] planos = new string[2, 82];
        WMPLib.WindowsMediaPlayer wplayer = new WMPLib.WindowsMediaPlayer();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            wplayer.URL = "C:\\Planos\\ViajeAstral2.mp3";
            wplayer.controls.play();
            Random r = new Random();
            int rand = r.Next(1, 82);
            pic_plano.Image = Image.FromFile("C:\\Planos\\" + rand + ".jpg");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            pic_plano.Image = Image.FromFile("C:\\Planos\\0.jpg");
        }

        private void Viajar_Destino_Click(object sender, EventArgs e)
        {
            if (panel1.Visible == false)
            {
                panel1.Visible = true;
                StreamReader sr = new StreamReader("C:\\Planos\\Lista_Planos2.txt");
                string listplanos = sr.ReadToEnd();
                string plano = null;
                int j = 1;
                char[] list_separada = listplanos.ToCharArray();
                for (int i = 1; i <= list_separada.Length; i++)
                {

                    if (list_separada[i - 1] != '.')
                    {
                        plano = plano + list_separada[i - 1];
                    }
                    else
                    {
                        planos[0, j - 1] = j.ToString(); //Numero de imagen
                        planos[1, j - 1] = plano; //Nombre del plano
                        j++;
                        plano = null;
                    }

                }
            }
            else
            {
                panel1.Visible = false;
            }
        }

        private void btn_Viajar_Click(object sender, EventArgs e)//Viaje directo
        {
            if (lista_planos.SelectedItem != null)
            {
                wplayer.URL = "C:\\Planos\\ViajeAstral2.mp3";
                wplayer.controls.stop();
                wplayer.controls.play();
                for (int i = 1; i <= 82; i++)
                {
                    if (planos[1, i - 1].Equals(lista_planos.SelectedItem))
                    {
                        pic_plano.Image = Image.FromFile("C:\\Planos\\" + planos[0, i - 1] + ".jpg");
                    }
                }
            }
        }
    }
}
