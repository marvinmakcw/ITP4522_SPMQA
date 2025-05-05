using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = true;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            lblMessage.Text = "It’s going to be a cloudy day today, " +txtName.Text + ".";
        }

        private void rdoRainy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = true;
            picSnowy.Visible = false;
            picSunny.Visible = false;
            lblMessage.Text = "It’s going to be a rainy day today, " + txtName.Text + ".";
        }

        private void rdoSnowy_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = true;
            picSunny.Visible = false;
            lblMessage.Text = "It’s going to be a snowy day today, " + txtName.Text + ".";
        }

        private void rdoSunny_CheckedChanged(object sender, EventArgs e)
        {
            picCloudy.Visible = false;
            picRainy.Visible = false;
            picSnowy.Visible = false;
            picSunny.Visible = true;
            lblMessage.Text = "It’s going to be a sunny day today, " + txtName.Text + ".";
        }
    }
}
