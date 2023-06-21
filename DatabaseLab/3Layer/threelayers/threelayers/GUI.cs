using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using threelayers.BUS;

namespace threelayers
{
    public partial class GUI : Form
    {
        int position = -1;
        private StudentBus stdBus;
        private DataSet currentDs;
        public GUI()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            stdBus = new StudentBus();
            currentDs = stdBus.getAll();
            dataGridView1.DataSource = currentDs.Tables[0];
            
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string classid = txtClass.Text;
            stdBus.insertStudent(id,name,classid);
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            position = e.RowIndex;
            if (position == -1)
            {
                MessageBox.Show("No row is selected!"); return;
            }
            DataRow row = currentDs.Tables[0].Rows[position]; 
            txtID.Text = row[0].ToString();
            txtName.Text = row[1].ToString();
            txtClass.Text = row[2].ToString();

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            string id = txtID.Text;
            string name = txtName.Text;
            string classid = txtClass.Text;
            stdBus.updateStudent(id, name, classid, position);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            stdBus.deleteStudent(position);
        }
    }
}
