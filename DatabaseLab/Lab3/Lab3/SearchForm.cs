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

namespace Lab3
{
    public partial class SearchForm : Form
    {
        String conn = global::Lab3.Properties.Settings.Default.STUDENT_MANAGERMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter;
        string strQuery;
        public SearchForm()
        {
            InitializeComponent();
        }

        private void sTUDENTBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGERMENTDataSet);

        }

        private void sTUDENTBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.sTUDENTBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGERMENTDataSet);

        }

        private void SearchForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGERMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGERMENTDataSet.STUDENT);

        }

        private void txtStudentName_TextChanged(object sender, EventArgs e)
        {
            strQuery = $"SELECT * FROM Student WHERE Name LIKE'%{txtStudentName.Text}%'";
            adapter = new SqlDataAdapter(strQuery, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            sTUDENTDataGridView.DataSource = ds.Tables[0];
        }
    }
}
