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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private DataTable dt = new DataTable();

        private void Form1_Load(object sender, EventArgs e)
        {
            string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                    + "Data Source=lib.accdb";
            string sqlStr = "Select * from Books";

            OleDbDataAdapter dataAdapter =
                            new OleDbDataAdapter(sqlStr, connStr);
            dataAdapter.Fill(dt);
            dataAdapter.Dispose();

        }

        private void btnShow_Click(object sender, EventArgs e)
        {
            string frmStr = "{0,-30}{1,-30}{2,-30}";
            lstOutput.Items.Clear();
            lstOutput.Items.Add(String.Format(frmStr, "Title",
                        "Author", "Publisher"));
            for (int i = 0; i < dt.Rows.Count; i++)
                lstOutput.Items.Add(String.Format(frmStr, dt.Rows[i]["Title"],
                            dt.Rows[i]["Author"], dt.Rows[i]["Publisher"]));

        }

        private void btnStatus_Click(object sender, EventArgs e)
        {
            Boolean bookFound = false;

            txtTitle.Clear();
            txtISBN.Clear();
            txtStatus.Clear();
            frmSearch frm = new frmSearch();
            DialogResult result = frm.ShowDialog();
            if (result == DialogResult.OK)
            {
                for (int i = 0; i < dt.Rows.Count; i++)
                    if (dt.Rows[i]["Title"].ToString().ToUpper().Equals(
                                frm.Result.ToUpper()))
                    {
                        bookFound = true;
                        txtTitle.Text = dt.Rows[i]["Title"].ToString();
                        txtISBN.Text = dt.Rows[i]["ISBN"].ToString();
                        txtStatus.Text = dt.Rows[i]["Status"].ToString();
                    }
                if (!bookFound)
                    MessageBox.Show("No such book can be found");
            }
        }

    }
}
