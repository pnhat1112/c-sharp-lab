using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        string connetionString = @"Data Source=SONNE;Initial Catalog=STUDENT_MANAGERMENT;Integrated Security=true";
        SqlDataAdapter adapter = null;
        DataSet ds = null;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter("SELECT * FROM Student", connetionString);
            SqlCommandBuilder sqlCommandBuilder = new SqlCommandBuilder(adapter);
            ds = new DataSet();
            adapter.Fill(ds, "Student");
            dtgViewStudents.DataSource = ds.Tables[0];
        }

        
        private void btnInsert_Click(object sender, EventArgs e)
        {
            int result = 0;
            DataRow dataRow = ds.Tables[0].NewRow();
            dataRow[0] = txtStudentID.Text;
            dataRow["Name"] = txtName.Text;
            dataRow[2] = txtClassID.Text;
            ds.Tables[0].Rows.Add(dataRow);

            try
            {
                adapter.Update(ds, "Student");
            } catch (Exception ex)
            {
                MessageBox.Show("Sai gì kìa cha \n"  + ex.Message);
            }
            if(result > 0)
            {
                MessageBox.Show("Chèn được rồi đó!");
            }
        }
        int possition = -1;
        private void dtgViewStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            possition = e.RowIndex;
            if(possition == -1)
            {
                MessageBox.Show("Hông có hàng nào được chọn kìa pa!");
                return;
            }
            DataRow dataRow = ds.Tables[0].Rows[possition];
            txtStudentID.Text = dataRow[0].ToString();
            txtName.Text = dataRow["Name"].ToString();
            txtClassID.Text = dataRow[2].ToString();
        }
        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (possition == -1)
            {
                MessageBox.Show("Hông có hàng nào được chọn kìa pa!");
                return;
            }
            DataRow dataRow = ds.Tables[0].Rows[possition];
            dataRow.BeginEdit();
            dataRow[0] = txtStudentID.Text;
            dataRow["Name"] = txtName.Text;
            dataRow[2] = txtClassID.Text;
            dataRow.EndEdit();
            int result = adapter.Update(ds.Tables[0]);
            if(result > 0)
            {
                MessageBox.Show("Update được zồi!");
            } else
            {
                MessageBox.Show("Sai gì rồi kìa cha!!");
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (possition == -1)
            {
                MessageBox.Show("Hông có hàng nào được chọn kìa pa!");
                return;
            }
            DataRow dataRow = ds.Tables[0].Rows[possition];
            dataRow.Delete();
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Delete được zồi!");
            }
            else
            {
                MessageBox.Show("Sai gì rồi kìa cha!!");
            }
        }

        
    }
}
