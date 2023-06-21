using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            listView1.View = View.Details;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if ((string.IsNullOrEmpty(textBox1.Text)) || (string.IsNullOrEmpty(textBox2.Text)))
            {
                MessageBox.Show("Vui lòng điền đủ thông tin");
            }
            else
            {
                ListViewItem item = new ListViewItem();
                item.Text = textBox1.Text;
                listView1.Items.Add(item);

                ListViewItem.ListViewSubItem subitem = new ListViewItem.ListViewSubItem(item, (textBox2.Text));
                item.SubItems.Add(subitem);

                textBox1.Clear();
                textBox2.Clear();
                textBox1.Focus();
            }
        }


        private void btnDel_Click(object sender, EventArgs e)
        {
            if (listView1.SelectedItems.Count > 0)
            {
                DialogResult dl = MessageBox.Show("Bạn muốn xóa", "Notice", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (dl == DialogResult.OK)
                    listView1.Items.Remove(listView1.SelectedItems[0]);
            }
            else MessageBox.Show("Xóa lỗi");
        }

        private void btnDelAll_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
        }

        private void btnOut_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
