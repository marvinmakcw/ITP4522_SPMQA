using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form3 : Form
    {
        private Form1 frm1;
        public Form3(Form1 frm)
        {
            InitializeComponent();
            this.frm1 = frm;
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'libDataSet.Books' table. You can move, or remove it, as needed.
            this.booksTableAdapter.Fill(this.libDataSet.Books);
            label1.Text = "Your books will be sent to " +
                frm1.Address + " on " + frm1.SendDate;

        }

        private void booksBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.booksBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.libDataSet);

        }
    }
}
