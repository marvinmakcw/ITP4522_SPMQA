using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab6
{
    public partial class frmSearch : Form
    {
        public frmSearch()
        {
            InitializeComponent();
        }

        public string Result { 
            get;
            set;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            Result = txtTitle.Text;
            Close();

        }
    }
}
