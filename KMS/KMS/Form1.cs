using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KMS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            double km, consumo, preço;
            double consumokms, despesa;
            km = double.Parse(txtkm.Text);
            consumo = double.Parse(txtConsumo.Text);
            preço = double.Parse(txtPreco.Text);
            consumokms = consumo / km * 100;
            despesa = preço * consumo;
            txtConsumo2.Text = consumokms.ToString();
            txtvalorgasto.Text = despesa.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtvalorgasto.Text = "";
            txtPreco.Text = "";
            txtkm.Text = "";
            txtConsumo2.Text = "";
            txtConsumo.Text = "";
            txtkm.Select();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
