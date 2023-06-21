using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnNhap_Click(object sender, EventArgs e)
        {
            if (!String.IsNullOrEmpty(txtName.Text))
            {
                listBox1.Items.Add(txtName.Text);
                txtSum.Text = listBox1.Items.Count.ToString();
                txtName.Clear();
                txtName.Focus();
            }
            else
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
        }

        private void btnXoaChon_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSum.Text);
            if (listBox1.SelectedItems.Count != 0)
            {
                listBox1.Items.Remove(listBox1.SelectedItems[0]);
            }
            txtSum.Text = (a - 1).ToString();
        }

        private void btnXoaDau_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSum.Text);
            listBox1.Items.RemoveAt(0);
            txtSum.Text = (a - 1).ToString();
        }

        private void btnXoaCuoi_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(txtSum.Text);
            listBox1.Items.RemoveAt(listBox1.Items.Count - 1);
            txtSum.Text = (a - 1).ToString();
        }

        private void btnXoaAll_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            txtSum.Text = "0";
        }

        private void btnChangeColor_Click(object sender, EventArgs e)
        {
            if (cbBoxColor.Text == "Yellow")
            {
                lbChangeColor.BackColor = Color.Red;
                lbChangeColor.ForeColor = Color.Yellow;
            }

            if (cbBoxColor.Text == "Red")
            {
                lbChangeColor.BackColor = Color.Yellow;
                lbChangeColor.ForeColor = Color.Red;
            }
            if (cbBoxColor.Text == "Blue")
            {
                lbChangeColor.BackColor = Color.Yellow;
                lbChangeColor.ForeColor = Color.Blue;
            }
            if (cbBoxColor.Text == "Black")
            {
                lbChangeColor.BackColor = Color.White;
                lbChangeColor.ForeColor = Color.Black;
            }
        }
    }
}
