using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libDataSet);

        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libDataSet.BorrowRecords' table. You can move, or remove it, as needed.
            this.borrowRecordsTableAdapter.Fill(this.libDataSet.BorrowRecords);
            // TODO: This line of code loads data into the 'libDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter.Fill(this.libDataSet.Users);

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
