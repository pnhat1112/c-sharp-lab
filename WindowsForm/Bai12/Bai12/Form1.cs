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

namespace Bai12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void coppyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Copy();
        }

        private void cutCtrlXToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Cut();
        }

        private void pasteCtrlVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Paste();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i;

            i = textBox1.SelectionStart;

            textBox1.Text = textBox1.Text.Remove(i, textBox1.SelectionLength);

            textBox1.SelectionStart = i;
        }

        private void selectAllCtrlAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.SelectAll();
        }

        private void undoCtrlZToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBox1.Undo();
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog f = new FontDialog();

            if (f.ShowDialog() == DialogResult.OK)

            {

                textBox1.Font = f.Font;

            }
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();

            if (c.ShowDialog() == DialogResult.OK)

            {

                textBox1.ForeColor = c.Color;

            }
        }

        private void wordWapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (textBox1.WordWrap == true)

            {

                wordWapToolStripMenuItem.Checked = false;

                textBox1.WordWrap = false;

            }

            else

            {

                wordWapToolStripMenuItem.Checked = true;

                textBox1.WordWrap = true;

            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
