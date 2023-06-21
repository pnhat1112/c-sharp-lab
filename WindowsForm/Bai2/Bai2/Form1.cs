using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtNum1.Text);
            b = Convert.ToDouble(txtNum2.Text);
            c = a + b;
            txtResult.Text = c.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtNum1.Text);
            b = Convert.ToDouble(txtNum2.Text);
            c = a - b;
            txtResult.Text = c.ToString();
        }

        private void btnNhan_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtNum1.Text);
            b = Convert.ToDouble(txtNum2.Text);
            c = a * b;
            txtResult.Text = c.ToString();
        }

        private void btnChia_Click(object sender, EventArgs e)
        {
            double a, b, c;
            a = Convert.ToDouble(txtNum1.Text);
            b = Convert.ToDouble(txtNum2.Text);
            c = a / b;
            txtResult.Text = c.ToString();
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            txtNum1.Clear();
            txtNum2.Clear();
        }

        private void txtNum1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }

        private void txtNum2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

            {

                e.Handled = true;

            }
        }
    }
}
