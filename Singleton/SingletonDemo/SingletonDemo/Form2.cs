using SingletonLib;
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

namespace SingletonDemo
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }


        static readonly SdbConnection dCon = SdbConnection.OpenConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlConnection sqlCon = dCon.GetConnection;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private SqlCommandBuilder sqlBuilder = null;
        private string sqlQuery = @"SELECT * FROM Docs";

        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                sqlDataAdapter = new SqlDataAdapter(sqlQuery, sqlCon);

                sqlBuilder = new SqlCommandBuilder(sqlDataAdapter);

                sqlBuilder.GetInsertCommand();
                sqlBuilder.GetUpdateCommand();
                sqlBuilder.GetDeleteCommand();

                dataSet = new DataSet();

                sqlDataAdapter.Fill(dataSet, "Docs");


                dataGridView1.Columns[0].DataPropertyName = "ID";
                dataGridView1.Columns[1].DataPropertyName = "DocName";
                dataGridView1.Columns[2].DataPropertyName = "Descr";
                dataGridView1.DataSource = dataSet.Tables["Docs"];
            }
            catch (Exception ex)
            {
            }
        }
    }
}
