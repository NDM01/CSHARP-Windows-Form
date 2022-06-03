using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IRS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            txtSalario.Select();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            const double IRS = 0.15;
            const double SS = 0.12;
            double salario, valorIRS, valorSS;
            salario = double.Parse(txtSalario.Text);
            valorIRS = salario * IRS;
            valorSS = salario * SS;
            txtirs.Text = valorIRS.ToString();
            txtSS.Text = valorSS.ToString();
            txtSL.Text = (salario - valorIRS - valorSS).ToString();



        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtSalario.Text = "";
            txtirs.Text = "";
            txtSL.Text = "";
            txtSS.Text = "";
            txtSalario.Select();

        }
    }
}
