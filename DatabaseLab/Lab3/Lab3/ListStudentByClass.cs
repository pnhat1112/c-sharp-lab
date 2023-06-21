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
    public partial class ListStudentByClass : Form
    {
        String conn = global::Lab3.Properties.Settings.Default.STUDENT_MANAGERMENTConnectionString;
        DataSet ds = null;
        SqlDataAdapter adapter;
        string strQuery;
        public ListStudentByClass()
        {
            InitializeComponent();
        }

        private void cLASSBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.cLASSBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.sTUDENT_MANAGERMENTDataSet);

        }

        private void ListStudentByClass_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'sTUDENT_MANAGERMENTDataSet.STUDENT' table. You can move, or remove it, as needed.
            this.sTUDENTTableAdapter.Fill(this.sTUDENT_MANAGERMENTDataSet.STUDENT);
            // TODO: This line of code loads data into the 'sTUDENT_MANAGERMENTDataSet.CLASS' table. You can move, or remove it, as needed.
            this.cLASSTableAdapter.Fill(this.sTUDENT_MANAGERMENTDataSet.CLASS);

        }

        private void btnView_Click(object sender, EventArgs e)
        {
            strQuery = $"SELECT * FROM Student WHERE ClassID='{classIDComboBox.Text}'";
            adapter = new SqlDataAdapter(strQuery, conn);
            ds = new DataSet();
            adapter.Fill(ds);
            sTUDENTDataGridView.DataSource = ds.Tables[0];
        }

    }
}
