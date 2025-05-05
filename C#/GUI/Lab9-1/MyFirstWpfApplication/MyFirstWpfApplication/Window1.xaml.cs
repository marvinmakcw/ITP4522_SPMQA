using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;


namespace MyFirstWpfApplication
{
    /// <summary>
    /// Interaction logic for Window1.xaml
    /// </summary>
    public partial class Window1 : Window
    {
        public Window1()
        {
            InitializeComponent();
        }

        private void Grid_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = "Provider=Microsoft.ACE.OLEDB.12.0;"
            + "Data Source=Employee.accdb";
            string sql = "Select * from Employees";
            OleDbConnection connection = new OleDbConnection(connectionString);
            OleDbDataAdapter dataadapter = new OleDbDataAdapter(sql, connection);
            DataSet EmpTable = new DataSet();
            connection.Open();
            dataadapter.Fill(EmpTable);
            DataContext = EmpTable.Tables[0];
            connection.Close();

        }
    }
}
