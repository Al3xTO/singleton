using SingletonLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SingletonDemo
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            SDocRepo docRepo = SDocRepo.GetInstance();

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
    }
}
