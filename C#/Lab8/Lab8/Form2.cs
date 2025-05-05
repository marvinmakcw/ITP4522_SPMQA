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
    public partial class Form2 : Form
    {
        private Form1 frm1;
        public Form2(Form1 frm)
        {
            InitializeComponent();
            this.frm1 = frm;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frm1.Address = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            frm1.SendDate = dateTimePicker1.Value.ToShortDateString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
