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
    public partial class Form1 : Form
    {
        SqlConnection conn = null;
        string connetionString = @"Data Source=SONNE;Initial Catalog=STUDENT_MANAGERMENT;Integrated Security=true";
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            
            try
            {
                conn = new SqlConnection(connetionString);
                conn.Open();
                MessageBox.Show("Succesful Connection!");

                /*string query = "SELECT * FROM STUDENT";
                SqlCommand cmd = new SqlCommand(query, conn);
                SqlDataReader read = cmd.ExecuteReader();
                while (read.Read())
                {
                    string output = "OUT: = " + read.GetValue(0) + "-" + read.GetValue(1) + "-" + read.GetValue(2);
                    MessageBox.Show(output);
                }*/
                /*string classID = "C01";
                String query = $"SELECT COUNT(*) FROM STUDENT WHERE ClassID = '{classID}'";
                SqlCommand command = new SqlCommand(query, conn);
                int result = Convert.ToInt32(command.ExecuteScalar());
                MessageBox.Show(result.ToString());*/
                Form2 form2 = new Form2();
                form2.Show();
            } catch (Exception ex)
            {
                MessageBox.Show("Failed to Connection " + ex.Message);
            }
            
        }

        private void btnDisConnect_Click(object sender, EventArgs e)
        {
            if(conn != null && conn.State==ConnectionState.Open)
            {
                conn.Close();
                MessageBox.Show("Succesful DisConnection!!!");
                this.Close();
            }
        }   
    }
}
