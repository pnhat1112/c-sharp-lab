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

namespace Lab4
{
    public partial class Form1 : Form
    {
        String conn = global::Lab4.Properties.Settings.Default.STUDENT_MANAGERMENTConnectionString;
        string sqlQuery = "SELECT * FROM Student";
        SqlDataAdapter adapter;
        DataTable tb;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            adapter = new SqlDataAdapter(sqlQuery, conn);
            tb = new DataTable();
            adapter.Fill(tb);

            for (int i = 0; i < tb.Rows.Count; i++)
            {
                ListViewItem row = new ListViewItem(tb.Rows[i][0].ToString());
                for (int j = 1; j < tb.Columns.Count; j++)
                    row.SubItems.Add(tb.Rows[i][j].ToString());
                lsViewStudent.Items.Add(row);
            }

        }
    }
}
