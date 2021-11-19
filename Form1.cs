using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace frmCalculadora2
{
    public partial class Calculadora : Form
    {
        decimal var1 = 0;
        decimal var2 = 0;
        string operacao = "";
        public Calculadora()
        {
            InitializeComponent();
        }

        private void button20_Click(object sender, EventArgs e)
        {
            txtResult.Text += button20.Text;
        }

        private void button15_Click(object sender, EventArgs e)
        {
            txtResult.Text += button15.Text;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            txtResult.Text += button13.Text;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            txtResult.Text += button11.Text;
        }

        private void button10_Click(object sender, EventArgs e)
        {
            txtResult.Text += button10.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            txtResult.Text += button8.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            txtResult.Text += button6.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            txtResult.Text += button1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            txtResult.Text += button3.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            txtResult.Text += button5.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(txtResult.Text);
            operacao = "SOMA";
            txtResult.Text = "";
        }

        private void button9_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(txtResult.Text);
            operacao = "SUB";
            txtResult.Text = "";
        }

        private void button14_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(txtResult.Text);
            operacao = "DIV";
            txtResult.Text = "";
        }

        private void button19_Click(object sender, EventArgs e)
        {
            var1 = Convert.ToDecimal(txtResult.Text);
            operacao = "MULTI";
            txtResult.Text = "";
        }

        private void button17_Click(object sender, EventArgs e)
        {
            var2 = Convert.ToDecimal(txtResult.Text);

            if (operacao == "SOMA")
            {
                txtResult.Text = Convert.ToString(var1 + var2);
            }
            if (operacao == "SUB")
            {
                txtResult.Text = Convert.ToString(var1 - var2);
            }
            if (operacao == "Multi")
            {
                txtResult.Text = Convert.ToString(var1 * var2);
            }
            if (operacao == "Div")
            {
                txtResult.Text = Convert.ToString(var1 / var2);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtResult.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            var1 = 0;
            var2 = 0;
            operacao = "";
            txtResult.Text = "";
        }
    }
}
