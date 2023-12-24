using SingletonLib;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace SingletonDemo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        static readonly SdbConnection dCon = SdbConnection.OpenConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = |DataDirectory|\DB.mdf; Integrated Security = True; Connect Timeout = 30");
        SqlConnection sqlCon = dCon.GetConnection;
        private SqlDataAdapter sqlDataAdapter = null;
        private DataSet dataSet = null;
        private SqlCommandBuilder sqlBuilder = null;
        private string sqlQuery = @"SELECT * FROM Docs";

        private void Form1_Load(object sender, EventArgs e)
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

            dataGridView1.MouseClick += Control_MouseClick;
            btn_NewForm.MouseClick += Control_MouseClick;
            btn_ListClear.MouseClick += Control_MouseClick;
            btn_ListDelItem.MouseClick += Control_MouseClick;
            btn_ListFill.MouseClick += Control_MouseClick;
            btn_NewListView.MouseClick += Control_MouseClick;
            lbl_ListBtnStatus.MouseClick += Control_MouseClick;


        }

        private void Control_MouseClick(object sender, MouseEventArgs e)
        {
            Control clickedControl = sender as Control;
            SLogInstance logger = SLogInstance.GetInstace("AppLog.txt");


            if (clickedControl != null)
            {
                string controlName = clickedControl.Name;
                logger.LogAction("UserName", $"натиснув елемент - {controlName}");
            }
        }

        
        private void btn_ListFill_Click(object sender, EventArgs e)
        {
            SDocRepo docRepo = SDocRepo.GetInstance();

            docRepo.ClearAll();
            for (int i=0; i<dataGridView1.Rows.Count-1;i++)
            {
                DataGridViewRow row = dataGridView1.Rows[i];
                Document doc = new Document((int)row.Cells[0].Value, (string)row.Cells[1].Value, (string)row.Cells[2].Value );
                docRepo.AddDocument(doc);
            }

            List<Document> list = docRepo.GetAllDocuments();
            listView1.Items.Clear();

            foreach (Document doc in list)
            {
                ListViewItem item = new ListViewItem(doc.DocId.ToString());
                item.SubItems.Add(doc.DocName);
                item.SubItems.Add(doc.DocDescr);

                listView1.Items.Add(item);
            }

        }

        private void btn_ListDelItem_Click(object sender, EventArgs e)
        {
            SDocRepo docRepo = SDocRepo.GetInstance();
            docRepo.RemoveDocument(int.Parse(listView1.SelectedItems[0].Text));

            listView1.Items.Remove(listView1.SelectedItems[0]);
        }
        private void btn_ListClear_Click(object sender, EventArgs e)
        {
            SDocRepo docRepo = SDocRepo.GetInstance();
            docRepo.ClearAll();
            listView1.Items.Clear();
        }
        private void btn_NewForm_Click(object sender, EventArgs e)
        {
            sqlDataAdapter.Update(dataSet, "Docs");
            Form form2 = new Form2();
            form2.Show();
        }

        private void btn_NewListView_Click(object sender, EventArgs e)
        {
            Form form3 = new Form3();
            form3.Show();
        }

        private void btn_DelRow_Click(object sender, EventArgs e)
        {
            if (this.dataGridView1.SelectedRows.Count==1)
            {
                
                dataSet.Tables["Docs"].Rows[this.dataGridView1.SelectedRows[0].Index].Delete();
                sqlDataAdapter.Update(dataSet, "Docs");
                
            }
        }

        private void grid_View_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {
            sqlDataAdapter.Update(dataSet, "Docs");
        }
    }
}
