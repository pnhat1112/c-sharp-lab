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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }
        SqlConnection conn = null;
        string connetionString = @"Data Source=SONNE;Initial Catalog=STUDENT_MANAGERMENT;Integrated Security=true";
        private void Form3_Load(object sender, EventArgs e)
        {
            if (conn == null) conn = new SqlConnection(connetionString);
            if (conn.State == ConnectionState.Closed) conn.Open();

            listBoxClass.ClearSelected();

            String queryGetClass = "SELECT * FROM CLASS";
            SqlCommand cmdGetClass = new SqlCommand(queryGetClass, conn);


            SqlDataReader readClass = cmdGetClass.ExecuteReader();
            while (readClass.Read())
            {
                string classID = readClass.GetString(0);
                string className = readClass.GetString(1);
                int year = readClass.GetInt32(2);
                string line = classID + "-" + className + "-" + year;
                listBoxClass.Items.Add(line);
            }
            conn.Close();


            lvStudents.Items.Clear();
            if (conn.State == ConnectionState.Closed) conn.Open();
            String queryGetStudent = "SELECT * FROM STUDENT";
            SqlCommand commandGetStudent = new SqlCommand(queryGetStudent, conn);
            SqlDataReader readStudent = commandGetStudent.ExecuteReader();

            while (readStudent.Read())
            {
                string studentID = readStudent.GetString(0);
                string nameStudent = readStudent.GetString(1);
                string classID1 = readStudent.GetString(2);

                ListViewItem item = new ListViewItem(studentID);
                item.SubItems.Add(nameStudent);
                item.SubItems.Add(classID1);
                lvStudents.Items.Add(item);
            }
            conn.Close();
        }

        private void listBoxClass_SelectedIndexChanged(object sender, EventArgs e)
        {
            lvStudents.Items.Clear();
            if (listBoxClass.SelectedIndex == -1) return;
            string line = listBoxClass.SelectedItem.ToString();
            string[] arr = line.Split('-');
            string classID = arr[0];

            if (conn == null) conn = new SqlConnection(connetionString);
            if (conn.State == ConnectionState.Closed) conn.Open();

            SqlCommand cmdGetListStudent = new SqlCommand($"SELECT * FROM STUDENT WHERE ClassID='{classID}'", conn);
            SqlDataReader readStudent = cmdGetListStudent.ExecuteReader();
            while(readStudent.Read())
            {
                string studentID = readStudent.GetString(0);
                string name = readStudent.GetString(1);
                string classIDRow = readStudent.GetString(2);

                ListViewItem item = lvStudents.Items.Add(studentID);
                item.SubItems.Add(name);
                item.SubItems.Add(classIDRow);
            }
            conn.Close();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            Form4 form4 = new Form4();
            form4.Show();
        }
    }
}
