using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Candidatos
{
    public partial class Form1 : Form
    {
        int CandA, CandB, CandC, CandD;
        int eleitores, vencedorVotos;

        private void btnCandA_Click(object sender, EventArgs e)
        {
            ++CandA;
            if(CandA>vencedorVotos)
            {
                vencedorVotos = CandA;
                vencedorCand = "Tino de ras";
            }
            ++eleitores;
        }

        private void btnCandB_Click(object sender, EventArgs e)
        {
            ++CandB;
            if (CandB > vencedorVotos)
            {
                vencedorVotos = CandB;
                vencedorCand = "Ana Gomes";
            }
            ++eleitores;
        }

        private void btnCandD_Click(object sender, EventArgs e)
        {
            ++CandD;
            if (CandD > vencedorVotos)
            {
                vencedorVotos = CandD;
                vencedorCand = "André Ventura";
            }
            ++eleitores;
        }

        private void btnTerminar_Click(object sender, EventArgs e)
        {
            btnTerminar.Enabled = false;
            this.Height = 450;
            txtvotosA.Text = CandA.ToString();
            txtCandA.Text = ((double)CandA / (double)eleitores).ToString("P2");

            txtvotosB.Text = CandB.ToString();
            txtCandB.Text = ((double)CandB / (double)eleitores).ToString("P2");

            txtvotosC.Text = CandC.ToString();
            txtCandC.Text = ((double)CandC / (double)eleitores).ToString("P2");

            txtvotosD.Text = CandD.ToString();
            txtCandD.Text = ((double)CandD / (double)eleitores).ToString("P2");

            txttotal.Text = eleitores.ToString();
            txtvencedor.Text = vencedorCand;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void txttotal_TextChanged(object sender, EventArgs e)
        {

        }

        string vencedorCand;
        public Form1()
        {
            InitializeComponent();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ++CandC;
            if (CandC > vencedorVotos)
            {
                vencedorVotos = CandC;
                vencedorCand = "Marcelo Rebelo de Sousa";
            }
            ++eleitores;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.Height =270;
        }
    }
}
