using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Diagnostics;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;
using System.Data.SqlClient;
using System.Data;

namespace WpfApp1HelloWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            string connectionString = @"data source = DESKTOP-Q5PLE8H\SQLEXPRESS; Initial Catalog = Lesson7; Integrated Security = True";
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand selectCmd = new SqlCommand("SELECT * FROM People", connection);
                adapter.SelectCommand = selectCmd;
                DataSet ds = new DataSet();
                adapter.Fill(ds);
                
                DataTable dt = ds.Tables[0];
                DataRow newRow = dt.NewRow();
                newRow["FIO"] = "Тестов Тест Тестович";
                newRow["Birthday"] = "25.05.2002";
                dt.Rows.Add(newRow);

                SqlCommandBuilder commandBuilder = new SqlCommandBuilder(adapter);
                adapter.Update(ds);
            }
        }
    }
}
