using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbTime.Text = String.Format("{0:hh:mm:ss tt}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());
            lbDate.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void toolStripComboBox1_Click(object sender, EventArgs e)
        {
            if (toolStripComboBox1.SelectedItem == "Hiển thị thời gian")
            {
                timer1.Start();
            }
            else if (toolStripComboBox1.SelectedItem == "Hiển thị ngày tháng")
            {
                timer2.Start();
            }
        }

        private void toolStripMenuItem2_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt == DialogResult.Yes)

            {

                Application.Exit();

            }
        }
    }
}
