using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            libDataSetTableAdapters.BooksTableAdapter ta = new libDataSetTableAdapters.BooksTableAdapter();
            libDataSet.BooksDataTable booksTable = new libDataSet.BooksDataTable();

            ta.Fill(booksTable);
            dgvBooks.DataSource = booksTable;

            libDataSetTableAdapters.UsersTableAdapter taUsers = new libDataSetTableAdapters.UsersTableAdapter();
            libDataSet.UsersDataTable usersTable = new libDataSet.UsersDataTable();

            taUsers.Fill(usersTable);
            dgvUsers.DataSource = usersTable;

        }
    }
}
