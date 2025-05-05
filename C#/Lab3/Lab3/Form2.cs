using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab3
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            double balance = Convert.ToDouble(txtAmount.Text);
            double rate = Convert.ToDouble(txtRate.Text);
            int year = 0;
            for (int i = 0; balance < 1000000; i++) {
                balance *= 1 + rate;
                year++;
                if (year == 10) {
                    lblValue2.Text = balance.ToString();
                }
            }
            lblMillion2.Text = year.ToString();
        }
    }
}
