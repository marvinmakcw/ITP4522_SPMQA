using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            using (var db = new sql6494233Entities())
            {
                var item = (from list in db.LstItems
                           select list);    // select * from employees

                foreach (var item2 in item.ToList())
                {
                    dataGridView1.Rows.Add(item2.ItemID, item2.ItemName, item2.ItemDescr, item2.ItemAmt, item2.ItemCat, item2.SupID);
                }
            }

        }
    }
}
