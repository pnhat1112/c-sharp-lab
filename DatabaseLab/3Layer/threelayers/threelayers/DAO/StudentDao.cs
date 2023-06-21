using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;
using NpgsqlTypes;

namespace threelayers.DAO
{
    internal class StudentDao
    {
        private dbConnection conn;
        public StudentDao()
        {
            conn = new dbConnection();
        }
        public DataSet getAll()
        {
            string query = "select * from Student";
            return conn.excuteQuery(query);
        }
        public void insertStudent(string id, string name, string classid)
        {
            conn.insertStudent(id,name,classid);
        }
        public void updateStudent(string id, string name, string classid, int position)
        {
            conn.updateStudent(id, name, classid, position);
        }
        public void deleteStudent(int position)
        {
            conn.deleteStudent(position);
        }
    }
}
