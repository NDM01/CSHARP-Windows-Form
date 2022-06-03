using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IMC
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btncalc_Click(object sender, EventArgs e)
        {
            double alt = 0, IMC = 0;
            int pes = 0;
            pes = decimal.ToInt32(ndpeso.Value);
            alt = decimal.ToDouble(ndalt.Value);
            IMC = pes / (alt * alt);
            txtimc.Text = IMC.ToString();
            if (rdmasc.Checked)
            {
                if (IMC <= 18.5)
                {
                    txtclasp.Text = "Peso Baixo";
                    txtrisc.Text = "Baixo";
                }
                else
                {
                    if (IMC >= 18.6 && IMC <= 24.9)
                    {
                        txtclasp.Text = "Peso Ideal";
                        txtrisc.Text = "Sem Risco";
                    }
                    else
                    {
                        if (IMC >= 25 && IMC <= 29.9)
                        {
                            txtclasp.Text = "Obesidade Leve";
                            txtrisc.Text = "Moderado";
                        }
                        else
                        {
                            if (IMC >= 30 && IMC <= 39.9)
                            {
                                txtclasp.Text = "Obesidade Moderada";
                                txtrisc.Text = "Alto";
                            }
                            else
                            {
                                txtclasp.Text = "Obesidade Severa";
                                txtrisc.Text = "Elevado";
                            }

                        }
                    }
                }
            }
            else
            {
                if (rdfem.Checked)
                {
                    if (IMC <= 17.9)
                    {
                        txtclasp.Text = "Peso Baixo";
                        txtrisc.Text = "Baixo";
                    }
                    else
                    {
                        if (IMC >= 18 && IMC <= 24.9)
                        {
                            txtclasp.Text = "Peso Ideal";
                            txtrisc.Text = "Sem Risco";
                        }
                        else
                        {
                            if (IMC >= 25 && IMC <= 27.2)
                            {
                                txtclasp.Text = "Obesidade Leve";
                                txtrisc.Text = "Moderado";
                            }
                            else
                            {
                                if (IMC >= 27.3 && IMC <= 38)
                                {
                                    txtclasp.Text = "Obesidade Moderada";
                                    txtrisc.Text = "Alto";
                                }
                                else
                                {
                                    txtclasp.Text = "Obesidade Severa";
                                    txtrisc.Text = "Elevado";
                                }

                            }
                        }
                    }
                }
            }
        }




        private void btnrepor_Click(object sender, EventArgs e)
        {
            txtimc.Text = "";
            txtclasp.Text = "";
            txtrisc.Text = "";
            txtid.Text = "";
            //ndalt.Value =;
            ndpeso.Value = 50;
            txtid.Select();

        }
    }
    
}
