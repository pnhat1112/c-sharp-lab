using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bạn vừa nhập: " + txtEnter.Text);
        }


        private void Form2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Modifiers == Keys.Alt && e.KeyCode == Keys.H)
            {
                txtEnter.Text = "Welcome !!!";
            }
        }

        private void Form2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                MessageBox.Show("Bạn vừa click chuột trái");
            }
            if (e.Button == MouseButtons.Right)
            {
                MessageBox.Show("Bạn vừa click chuột phải");
            }
            if (e.Button == MouseButtons.Middle)
            {
                MessageBox.Show("Bạn vừa click chuột giữa");
            }
        }
    }
}
