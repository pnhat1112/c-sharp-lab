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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string connetionString = @"Data Source=SONNE;Initial Catalog=STUDENT_MANAGERMENT;Integrated Security=true";
        private void Form4_Load(object sender, EventArgs e)
        {
            ViewListStudent();
        }
        int result = -1;
        private void btnInsert_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(connetionString);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand cmd = new SqlCommand();
            cmd.CommandType = CommandType.Text;
            cmd.Connection = conn;
            cmd.CommandText = "INSERT INTO Student(StudentID,Name,ClassID)" 
                + "VALUES(@StudentID,@Name,@ClassID)";
            SqlParameter parameter_StudentID = new SqlParameter("@StudentID", txtStudentID.Text);
            cmd.Parameters.Add(parameter_StudentID);
            SqlParameter parameter_Name = new SqlParameter("@Name", txtName.Text);
            cmd.Parameters.Add(parameter_Name);
            SqlParameter parameter_ClassID = new SqlParameter("@ClassID", txtClassID.Text);
            cmd.Parameters.Add(parameter_ClassID);

            try {
                result = cmd.ExecuteNonQuery();
            } catch(Exception ex) {
                MessageBox.Show(ex.Message + "\n Insert Failed!!");
            }
            if(result > 0)
            {
                ViewListStudent();
            }
        }
        private void ViewListStudent()
        {
            if (conn == null) conn = new SqlConnection(connetionString);
            if (conn.State == ConnectionState.Closed) conn.Open();

            lsvStudents.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            String queryGetStudent = "SELECT * FROM STUDENT";
            SqlCommand commandGetStudent = new SqlCommand(queryGetStudent, conn);
            SqlDataReader readStudent = commandGetStudent.ExecuteReader();

            while (readStudent.Read())
            {
                string studentID = readStudent.GetString(0);
                string nameStudent = readStudent.GetString(1);
                string classID1 = readStudent.GetString(2);

                ListViewItem item = lsvStudents.Items.Add(studentID);
                item.SubItems.Add(nameStudent);
                item.SubItems.Add(classID1);
            }
            conn.Close();
        }

        private void lsvStudents_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(lsvStudents.SelectedItems.Count > 0)
            {
                txtStudentID.Text = lsvStudents.SelectedItems[0].SubItems[0].Text;
                txtName.Text = lsvStudents.SelectedItems[0].SubItems[1].Text;
                txtClassID.Text = lsvStudents.SelectedItems[0].SubItems[2].Text;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(connetionString);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand cmd = new SqlCommand($"UPDATE Student SET Name='{txtName.Text}', ClassID='{txtClassID.Text}' WHERE StudentID='{txtStudentID.Text}'", conn);

            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Update Failed!!");
            }
            if (result > 0)
            {
                ViewListStudent();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(connetionString);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand cmd = new SqlCommand($"DELETE FROM Student WHERE StudentID='{txtStudentID.Text}'", conn);

            try
            {
                result = cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message + "\n Delete Failed!!");
            }
            if (result > 0)
            {
                ViewListStudent();
                txtStudentID.Text = "";
                txtName.Text = "";
                txtClassID.Text = "";

            }
        }
    }
}
