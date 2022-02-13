using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace RowGroup_Sample
{
    public partial class Form1 : DevExpress.XtraEditors.XtraForm
    {
        String ConnectionString = ConfigurationManager.ConnectionStrings["ConnectionString"].ConnectionString;
        public Form1()
        {
            InitializeComponent();
        }
        private DataTable table = new DataTable();
        private void tableItems()
        {
            //table.Columns.Add(new DataColumn("NAME", typeof(int)));
            table.Columns.Add(new DataColumn("COMPANY", typeof(string)));
            table.Columns.Add(new DataColumn("DATE", typeof(string)));
            table.Columns.Add(new DataColumn("SOA NO.", typeof(string)));
            table.Columns.Add(new DataColumn("AMOUNT", typeof(string)));
            table.Columns.Add(new DataColumn("ADVANCE", typeof(string)));
            table.Columns.Add(new DataColumn("BALANCE", typeof(string)));
            table.Columns.Add(new DataColumn("REBATES", typeof(string)));

            table.Rows.Add("DIADEM REMINAL MARITIME", "12-OCT-21", "3338", "10,959", "2,000", "8,959", "2,000");
            table.Rows.Add("DIADEM REMINAL MARITIME", "1-OCT-21", "3339", "8,000", "3,000", "5,000", "1,000");
            table.Rows.Add("DIADEM REMINAL MARITIME", "23-SEPT-21", "3340", "12,000", "2,000", "10,000", "2,000");
            table.Rows.Add("DIADEM REMINAL MARITIME", "3-SEPT-21", "3341", "9,500", "3,000", "6,500", "2,000");

            table.Rows.Add("SHIPCO TRANSPORT", "12-OCT-21", "4440", "10,959", "2,000", "8,959", "3,000");
            table.Rows.Add("SHIPCO TRANSPORT", "1-OCT-21", "4441", "8,000", "3,000", "5,000", "2,000");
            table.Rows.Add("SHIPCO TRANSPORT", "23-SEPT-21", "4442", "12,000", "2,000", "10,000", "3,000");
            table.Rows.Add("SHIPCO TRANSPORT", "3-SEPT-21", "4443", "9,500", "3,000", "6,500", "2,000");
            table.Rows.Add("SHIPCO TRANSPORT", "3-SEPT-21", "4444", "9,500", "3,000", "6,500", "2,000");

            gridControl1.DataSource = table;
            gridView1.ExpandAllGroups();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            tableItems();
        }
    }
}
