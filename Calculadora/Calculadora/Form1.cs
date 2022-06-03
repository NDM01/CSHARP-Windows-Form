using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
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

        private void button1_Click(object sender, EventArgs e)
        {
            int op1, op2;
            double res;
            op1 = int.Parse(txtop1.Text);
            op2 = int.Parse(txtop2.Text);
            switch(txtoperador.Text)
            {
                case "+":
                    res = op1 + op2;
                    txtres.Text = res.ToString();
                    break;
                case "-":
                    res = op1 - op2;
                    txtres.Text = res.ToString();
                    break;
                case "*":
                    res = op1 * op2;
                    txtres.Text = res.ToString();
                    break;
                case "/":
                    if (op2 == 0)
                    {
                        txtres.Text = "Não pode dividir por 0!";
                        txtop2.Text = "";
                        txtop2.Select();
                    }
                    else
                    {
                        res = op1 / op2;
                        txtres.Text = res.ToString();
                    }
                    break;
                    default:
                    txtres.Text = "Insira um operador válido(+,-,*,/)";
                    txtoperador.Text = "";
                    txtoperador.Select();
                    break;

                    
                      
            }
          



        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtop1.Select();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtop1.Text = "";
            txtop2.Text = "";
            txtoperador.Text = "";
            txtres.Text = "";
            txtop1.Select();

        }
    }
}
