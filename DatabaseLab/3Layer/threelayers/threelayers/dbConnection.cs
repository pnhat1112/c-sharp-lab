using Npgsql;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace threelayers
{
    internal class dbConnection
    {
        private SqlConnection conn;
        private SqlDataAdapter adapter;
        private DataSet ds;
        private string strconn = @"Data Source=SONNE;Initial Catalog=STUDENT_MANAGERMENT;Integrated Security=true";
        public dbConnection()
        {
            try
            {
                conn = new SqlConnection(strconn);
                conn.Open();
                MessageBox.Show("Succesful Connection!");
            } catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }

            
        }

        public DataSet excuteQuery(string _query)
        {
            ds = new DataSet();
            try
            {
                adapter = new SqlDataAdapter(_query, strconn);
                SqlCommandBuilder builder = new SqlCommandBuilder(adapter);
                ds = new DataSet();
                adapter.Fill(ds, "Student");
            }
            catch (NpgsqlException e)
            {
                MessageBox.Show(e.ToString());
            }
            return ds;
        }

        public void insertStudent(string id, string name, string classid)
        {
            int result = 0;
            DataRow row = ds.Tables[0].NewRow();
            row[0] = id;
            row[1] = name;
            row[2] = classid;
            ds.Tables[0].Rows.Add(row);
            try
            {
                result = adapter.Update(ds, "Student");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Sth went wrong!!,{ex.ToString()}");
            }
            if (result > 0)
            {
                MessageBox.Show("Insert Successfully!");
            }
            else
            {
                MessageBox.Show("Insert Failled!");
            }

        }

        public void updateStudent(string id, string name, string classid, int position)
        {
            if (position == -1)
            {
                MessageBox.Show("No row is selected!");
                return;
            }
            DataRow row = ds.Tables[0].Rows[position];
            row.BeginEdit();
            row[0] = id;
            row[1] = name;
            row[2] = classid;
            row.EndEdit();
            int result = adapter.Update(ds.Tables[0]);
            if (result > 0)
            {
                MessageBox.Show("Update Successfully!");
            }
            else
            {
                MessageBox.Show("Update Failled!");
            }

        }
        public void deleteStudent(int position)
        {
            if (position == -1)
            {
                MessageBox.Show("No row is selected!"); return;
            }
            DataRow row = ds.Tables[0].Rows[position]; row.Delete();
            int result = adapter.Update(ds.Tables[0]); 
            if (result > 0)
            {
                MessageBox.Show("Delete Successfully!");
            }
            else
            {
                MessageBox.Show("Delete Failled!");
            }

        }

    }
}
