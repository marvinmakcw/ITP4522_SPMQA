using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Lab6
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable();
        private int rowIndex;

        private void Form2_Load(object sender, EventArgs e)
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                    + "Data Source=lib.accdb";
            string sqlStr = "Select BookID, Title, Publisher, ISBN from Books";

            OleDbDataAdapter dataAdapter =
                            new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();

            cboISBN.DataSource = dt;
            cboISBN.DisplayMember = "ISBN";

        }

        private void cboISBN_Click(object sender, EventArgs e)
        {
            /*rowIndex = cboISBN.SelectedIndex;
            lblDisplay.Text = "The ID of the book selected is "
                    + Convert.ToString(dt.Rows[rowIndex]["BookID"]);*/
        }

        private void bnFirst_Click(object sender, EventArgs e)
        {
            rowIndex = 0;
            UpdateTextBoxes();

        }

        private void cboISBN_SelectedIndexChanged(object sender, EventArgs e)
        {
            rowIndex = cboISBN.SelectedIndex;
            lblDisplay.Text = "The ID of the book selected is "
                    + Convert.ToString(dt.Rows[rowIndex]["BookID"]);

        }

        private void UpdateTextBoxes()
        {
            txtTitle.Text = dt.Rows[rowIndex]["Title"].ToString();
            txtPublisher.Text = dt.Rows[rowIndex]["Publisher"].ToString();
        }

        private void btnPrevious_Click(object sender, EventArgs e)
        {
            if (rowIndex > 0)
            {
                rowIndex--;
                UpdateTextBoxes();
            }

        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (rowIndex < dt.Rows.Count - 1)
            {
                rowIndex++;
                UpdateTextBoxes();
            }

        }

        private void btnLast_Click(object sender, EventArgs e)
        {
            rowIndex = dt.Rows.Count - 1;
            UpdateTextBoxes();

        }
    }
}
