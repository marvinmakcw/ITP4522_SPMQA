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

namespace Lab7
{
    public partial class FormLogin : Form
    {
        public bool Login = false;
        private string connStr = "Provider=Microsoft.ACE.OLEDB.12.0;"
                    + "Data Source=lib.accdb";


        public FormLogin()
        {
            InitializeComponent();
            Login = false;
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
			string sqlStr = "";
			Login = false;

			if (txtUsername.Text.Length == 0 ||
					txtPassword.Text.Length == 0)
			{
				MessageBox.Show("Missing username or password. "
							+ "Please try again.");
				txtUsername.Clear();
				txtPassword.Clear();
			}
			else
			{
				try
				{
					DataTable dt = new DataTable();
					sqlStr = "SELECT * FROM Users WHERE Username = '" + txtUsername.Text + "'";
					OleDbDataAdapter dataAdapter =
							new OleDbDataAdapter(sqlStr, connStr);
					dataAdapter.Fill(dt);
					dataAdapter.Dispose();
					for (int i = 0; i < dt.Rows.Count && !Login; i++)
						if (txtUsername.Text.Equals(dt.Rows[i]["Username"])
						&& txtPassword.Text.Equals(dt.Rows[i]["Password"]))
							Login = true;

					if (Login)
						Close();
					else
					{
						MessageBox.Show("Incorrect user name or password. "
							+ "Please try again.");
						txtUsername.Clear();
						txtPassword.Clear();
					}
				}
				catch (Exception ex)
				{
					MessageBox.Show(ex.Message + "\nSQL: " + sqlStr);
				}
			}


		}

		private void btnCancel_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
