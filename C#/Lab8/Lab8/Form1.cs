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
    public partial class Form1 : Form
    {
        public string Address { get; set; }
        public string SendDate { get; set; }

        private Form2 frm2;
        private Form3 frm3;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void enterCustomerInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm2 = new Form2(this);
            frm2.MdiParent = this;
            frm2.Dock = DockStyle.Fill;
            if (frm3 != null)
                frm3.Close();
            frm2.Show();

        }

        private void viewBooksToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm3 = new Form3(this);
            frm3.MdiParent = this;
            frm3.Dock = DockStyle.Fill;
            if (frm2 != null)
                frm2.Close();
            frm3.Show();


        }
    }
}
