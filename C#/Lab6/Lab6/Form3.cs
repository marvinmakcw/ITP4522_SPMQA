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
    public partial class Form3 : Form
    {
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
           + "Data Source=lib.accdb";
        /*private string sqlStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
           + "Data Source=lib.accdb";*/
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            UpdateGrid("Select * from Users");
        }
        public void UpdateGrid(string sql)
        {
            try
            {
                DataTable dt = new DataTable();
                OleDbDataAdapter dataAdapter =
                            new OleDbDataAdapter(sql, connStr);
                dataAdapter.Fill(dt);
                dataAdapter.Dispose();
                dgvDisplay.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnShowBook_Click(object sender, EventArgs e)
        {
            UpdateGrid("Select * from Books order by Author");
        }

        private void btnSQL_Click(object sender, EventArgs e)
        {
            UpdateGrid(txtSQL.Text);
        }
    }
}
