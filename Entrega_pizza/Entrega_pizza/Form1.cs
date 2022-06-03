using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Entrega_pizza
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

        private void button1_Click(object sender, EventArgs e)
        {
            double total, i;
            i = 0;
            if (radioButton5.Checked == true)
                total = 6.0;
            else if (radioButton4.Checked == true)
                total = 8.0;
            else
                total = 12.0;
            i = checkedListBox1.CheckedItems.Count;
            if (i == 0)
            {
                MessageBox.Show("Escolha pelo menos um dos ingredienes");
                textBox1.Text = null;
            }
            else
            {
                total = total + (i * 3.0);
                textBox1.Text = Convert.ToString(total) + " € ";
            }
        }


        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            radioButton3.Checked = true;
            radioButton1.Checked = true;
            foreach (int checados in checkedListBox1.CheckedIndices)
            {
                checkedListBox1.SetItemChecked(checados, false);
            }
        }
    }  }
