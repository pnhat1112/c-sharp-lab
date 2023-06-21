using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Bai5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtName.Text) || !string.IsNullOrWhiteSpace(txtPassword.Text))
            {
                MessageBox.Show("Đăng nhập thành công !!!");
            }
            else
            {
                MessageBox.Show("Vui lòng điền đầy đủ thông tin !!!");
            }
        }

        private void txtPassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!(e.KeyChar >= '0' && e.KeyChar <= '9' || e.KeyChar == (char)8))
                e.Handled = true;
        }

        private void cBoxShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (cBoxShowPassword.Checked == true)
            {
                txtPassword.PasswordChar = (char)0;
            }
            else
            {
                txtPassword.PasswordChar = '*';
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(txtName, "Chỉ được nhập ký tự a-z và 0-9");
            toolTip1.SetToolTip(txtPassword, "Chỉ được nhập ký tự từ 0-9");
            helpProvider1.HelpNamespace = "mailto:pdmnhat.19it3@vku.udn.vn";
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }
    }
}
