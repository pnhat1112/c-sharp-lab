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

namespace Lab1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string connetionString = @"Data Source=SONNE;Initial Catalog=STUDENT_MANAGERMENT;Integrated Security=true";

        private void btnCalculateNumberStudents_Click(object sender, EventArgs e)
        {
            if (conn == null)
            {
                conn = new SqlConnection(connetionString);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String query = $"SELECT COUNT(*) FROM STUDENT WHERE ClassID = '{txtEnterClassID.Text}'";
            String queryGetClass = $"SELECT * FROM CLASS WHERE ClassID = '{txtEnterClassID.Text}'";
            SqlCommand command = new SqlCommand(query, conn);
            SqlCommand commandGetClass =  new SqlCommand(queryGetClass, conn);

            int result = Convert.ToInt32(command.ExecuteScalar());
            txtNumberStudents.Text = result.ToString();

            SqlDataReader read = commandGetClass.ExecuteReader();
            while (read.Read())
            {
                txtClassID.Text = read.GetString(0);
                txtClassName.Text = read.GetString(1);
                txtYear.Text = read.GetInt32(2).ToString();
            }
            conn.Close();
        }

        private void btnViewListStudents_Click(object sender, EventArgs e)
        {
            lsvStudents.Items.Clear();
            if (conn == null)
            {
                conn = new SqlConnection(connetionString);
            }
            if (conn.State == ConnectionState.Closed)
            {
                conn.Open();
            }
            String queryGetStudent = $"SELECT * FROM STUDENT WHERE ClassID = '{txtEnterClassID.Text}'";
            SqlCommand commandGetStudent = new SqlCommand(queryGetStudent, conn);
            SqlDataReader read = commandGetStudent.ExecuteReader();
            while (read.Read())
            {
                string studentID = read.GetString(0);
                string nameStudent =  read.GetString(1);
                string classID = read.GetString(2);

                ListViewItem item = new ListViewItem(studentID);
                item.SubItems.Add(nameStudent);
                item.SubItems.Add(classID);

                lsvStudents.Items.Add(item);
            }
            conn.Close();
        }

        private void btnViewAllTable_Click(object sender, EventArgs e)
        {
            try
            {
                Form3 form3 = new Form3();
                form3.Show();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Connection " + ex.Message);
            }
            
        }
    }
}
