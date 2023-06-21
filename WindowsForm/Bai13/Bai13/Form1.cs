using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai13
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txtID.Text) || string.IsNullOrEmpty(txtName.Text) || string.IsNullOrEmpty(txtPassword.Text))

            {

                MessageBox.Show("You have not entered full information !!", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            else

            {

                // tạo mới một ListViewItem

                ListViewItem lstvItem = new ListViewItem();

                lstvItem.Text = txtName.Text;

                ListViewItem.ListViewSubItem lstvsub = new ListViewItem.ListViewSubItem(lstvItem, txtPassword.Text);

                ListViewItem.ListViewSubItem lstvsub1 = new ListViewItem.ListViewSubItem(lstvItem, txtID.Text);

                // thêm các thông tin vào các cột tương ứng trong ListView

                lstvItem.SubItems.Add(lstvsub);

                lstvItem.SubItems.Add(lstvsub1);

                listView1.Items.Add(lstvItem);

                MessageBox.Show("You have successfuly added your account", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // sau khi thêm thông tin ta sẽ xóa các thông tin đã nhập ở các ô textbox để có thể nhập và thêm mới tài khoản khác.

                txtID.Clear();

                txtName.Clear();

                txtPassword.Clear();

            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedIndices.Count <= 0)

            {

                MessageBox.Show("You have not selected the item you want to delete", "Notify", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }

            if (listView1.SelectedIndices.Count > 0)

            {

                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);

                if (dl == DialogResult.OK)

                    listView1.Items.Remove(listView1.SelectedItems[0]);

            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
