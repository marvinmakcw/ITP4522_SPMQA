using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testDatabase
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
                var staff = (from list in db.lstStaffs
                           select list);    

                foreach (var staff2 in staff.ToList())
                {
                    dataGridView1.Rows.Add(staff2.staffId, staff2.staffFName);
                }
            }

        }
    }
}
