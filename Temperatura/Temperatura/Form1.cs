using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Temperatura
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtcel.Text = "";
            txtfar.Text = "";
            txtkel.Text = "";
            rdcel.Checked = true;
            txtcel.Select();
        }

        private void rdcel_CheckedChanged(object sender, EventArgs e)
        {
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            rdcel.Checked= true;
            txtcel.Select();
        }

        private void txtcel_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtfar_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            double fa=0, kel=0, ce=0; 
            if (rdcel.Checked)
            {   
                ce = double.Parse(txtcel.Text);
                fa = (ce * 1.8000) + 32.00;
                kel = ce + 273.15;
                txtfar.Text = fa.ToString();
                txtkel.Text = kel.ToString();
            }
            else
            {
                if (rdfar.Checked)
                {
                    fa = double.Parse(txtfar.Text);
                    ce = (fa - 32) / 1.8000;
                    kel = (fa - 32) / 1.800 + 273.15;
                    txtcel.Text = ce.ToString();
                    txtkel.Text = kel.ToString();
                }

                else
                {

                    if (rdkel.Checked)
                    {
                        kel = double.Parse(txtkel.Text);
                        ce = kel - 273.15;
                        fa = (kel - 273.15) * 1.800 + 32.00;
                        txtcel.Text = ce.ToString();
                        txtfar.Text = fa.ToString();
                    }



                }
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
