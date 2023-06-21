using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai6
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
            lbGio.Text = String.Format("{0:hh:mm:ss tt}", dt);
            lbNgayThang.Text = String.Format("{0:dd/MM/yyyy}", dt);
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            Form2 frm = new Form2();
            progressBar1.Increment(1);
            label1.Text = "Connecting to from " + progressBar1.Value.ToString() + "%";
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer2.Enabled = false;
                frm.ShowDialog();
            }
        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            if (progressBar1.Enabled == true)
            {
                progressBar1.Enabled = false;
                timer2.Start();
                timer1.Start();
            }
            else
            {
                progressBar1.Enabled = true;
                timer2.Stop();
                timer1.Stop();

            }
        }
    }
}
