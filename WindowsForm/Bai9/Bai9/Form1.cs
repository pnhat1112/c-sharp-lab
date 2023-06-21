using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Bai9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnBook_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtEmail.Text) || string.IsNullOrEmpty(txtSdt.Text))

            {

                MessageBox.Show("Bạn chưa nhập đầy đủ thông tin");

            }
            else if (!string.IsNullOrEmpty(txtName.Text) || !string.IsNullOrEmpty(txtSdt.Text) || !string.IsNullOrEmpty(txtEmail.Text) == true)

            {   
                label1.Text = "From: " + dateTimePicker1.Value.ToShortDateString() + "To: " + dateTimePicker2.Value.ToShortDateString();
                label2.Text = "Name: " + txtName.Text;
                label3.Text = "Sđt: " + txtSdt.Text;
                label4.Text = "Email: " + txtEmail.Text;
                label5.Text = "Phòng ở: " + cbBoxRoom.Text;
            }
        }

        private void txtName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!((e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar == ' ') || (e.KeyChar >= 'A' && e.KeyChar <= 'Z') || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void txtSdt_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))

                e.Handled = true;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            dateTimePicker1.MinDate = DateTime.Now;

            int dayofmonth = DateTime.DaysInMonth(DateTime.Now.Year, DateTime.Now.Month);

            dateTimePicker1.MaxDate = new DateTime(DateTime.Now.Year, DateTime.Now.Month, dayofmonth);

            dateTimePicker2.MinDate = DateTime.Now;

        }
    }
}
