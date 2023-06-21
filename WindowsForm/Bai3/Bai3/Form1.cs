using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Bai3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnMusic_Click(object sender, EventArgs e)
        {
            string str = "";
            if (cboxClassic.Checked == true)
            {
                str = cboxClassic.Text + "\n";
            }
            if (cboxEDM.Checked == true)
            {
                str = str + cboxEDM.Text + "\n";
            }
            if (cboxPop.Checked == true)
            {
                str = str + cboxPop.Text + "\n";
            }
            if (cboxRock.Checked == true)
            {
                str = str + cboxRock.Text + "\n";
            }
            if (cboxVinahouse.Checked == true)
            {
                str = str + cboxVinahouse.Text;
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Your Music: \n" + str);
            }
            else
            {
                MessageBox.Show("Don't Have Music Your Choice");
            }
        }

        private void btnColor_Click(object sender, EventArgs e)
        {
            string str = "";
            if (rdoBtnDen.Checked == true)
            {
                str = rdoBtnDen.Text + "\n";
            }
            if (rdoBtnRed.Checked == true)
            {
                str = str + rdoBtnRed.Text + "\n";
            }
            if (rdoBtnTrang.Checked == true)
            {
                str = str + rdoBtnTrang.Text + "\n";
            }
            if (rdoBtnXanhLa.Checked == true)
            {
                str = str + rdoBtnXanhLa.Text + "\n";
            }
            if (rdoXanhTroi.Checked == true)
            {
                str = str + rdoXanhTroi.Text;
            }
            if (str.Length > 0)
            {
                MessageBox.Show("Your Color: \n" + str);
            }
            else
            {
                MessageBox.Show("Don't Have Color Your Choice");
            }
        }
    }
}
