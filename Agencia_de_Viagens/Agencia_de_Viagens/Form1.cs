using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viagens
{
    public partial class Form1 : Form
    {
        FileInfo[] pasta;
        int maximo;
        public Form1()
        {
            InitializeComponent();
            DirectoryInfo imagem = new DirectoryInfo(".\\Imagens");
            pasta = imagem.GetFiles();
            maximo = imagem.GetFiles().Length;
            pictureBox1.ImageLocation = pasta[0].FullName;
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            toolTip1.SetToolTip(pictureBox1, pasta[0].FullName);
            numericUpDown1.Maximum = maximo - 1;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtres.Text = "Parabéns! vai viajar para as Maldivas";
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            int valor;
            valor = (int)numericUpDown1.Value;
            pictureBox1.ImageLocation = pasta[valor].FullName;
            toolTip1.SetToolTip(pictureBox1, pasta[valor].FullName);
            if (valor == 0)
            {
                txtres.Text = "Parabéns! vai viajar para as Maldivas";
            }
            else
            {
                if (valor == 1)
                {



                    txtres.Text = "Parabéns! vai viajar para Portugal";
                }
                else
                {
                    if (valor == 2)
                    {
                        txtres.Text = "Parabéns! vai viajar para os EUA";
                    }
                    else
                    {
                        txtres.Text = "Parabéns! vai viajar para o Brasil";
                    }
                }
            }
        }
    }
}
