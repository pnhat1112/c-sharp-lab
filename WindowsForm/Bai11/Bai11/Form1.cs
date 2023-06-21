using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai11
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

        private void displayTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            lbTime.Text = String.Format("{0:hh:mm:ss tt}", dt);

        }

        private void displayDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dt = DateTime.Now.Add(new TimeSpan());

            lbDate.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void menuExitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dt = MessageBox.Show("Bạn muốn đóng chương trình", "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (dt == DialogResult.Yes)

            {

                Application.Exit();

            }
        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {
                contextMenuStrip1.Show(PointToScreen(e.Location));
            }
            else
            {
            }
        }
    }
}
