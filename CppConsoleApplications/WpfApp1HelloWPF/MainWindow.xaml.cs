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
        SqlConnection connection;
        SqlDataAdapter adapter;
        DataTable dt;
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            string connectionString = @"data source = DESKTOP-Q5PLE8H\SQLEXPRESS; Initial Catalog = Lesson7; Integrated Security = True";
            connection = new SqlConnection(connectionString);
            adapter = new SqlDataAdapter();
            SqlCommand selectCommand = new SqlCommand(@"SELECT Id,FIO,Birthday,Email,Phone FROM People",connection);
            adapter.SelectCommand = selectCommand;
            SqlCommand insertCommand = new SqlCommand(@"INSERT INTO People (FIO,Birthday,Email,Phone) VALUES (@FIO,@Birthday,@Email,@Phone); SET @ID = @@IDENTITY;",connection);
            insertCommand.Parameters.Add("@FIO", SqlDbType.VarChar,256,"FIO");
            insertCommand.Parameters.Add("@Birthday", SqlDbType.VarChar,256,"Birthday");
            insertCommand.Parameters.Add("@Email", SqlDbType.VarChar,100,"Email");
            insertCommand.Parameters.Add("@Phone", SqlDbType.VarChar,100,"Phone");
            var insertParam = insertCommand.Parameters.Add("@ID",SqlDbType.Int,0,"ID");
            insertParam.Direction = ParameterDirection.Output;
            adapter.InsertCommand = insertCommand;
            SqlCommand updateCommand = new SqlCommand(@"UPDATE People SET FIO=@FIO,Birthday=@Birthday,Email=@Email,Phone=@Phone WHERE ID=@ID",connection);
            updateCommand.Parameters.Add("@FIO", SqlDbType.VarChar,256,"FIO");
            updateCommand.Parameters.Add("@Birthday", SqlDbType.VarChar,256,"Birthday");
            updateCommand.Parameters.Add("@Email", SqlDbType.VarChar,100,"Email");
            updateCommand.Parameters.Add("@Phone", SqlDbType.VarChar,100,"Phone");
            var updateParam = updateCommand.Parameters.Add("@ID",SqlDbType.Int,0,"ID");
            updateParam.SourceVersion = DataRowVersion.Original;
            adapter.UpdateCommand = updateCommand;
            SqlCommand deleteCommand = new SqlCommand(@"DELETE FROM People WHERE ID=@ID",connection);
            var deleteParam = deleteCommand.Parameters.Add("@ID",SqlDbType.Int,0,"ID");
            deleteParam.SourceVersion = DataRowVersion.Original;
            adapter.DeleteCommand = deleteCommand;
            dt = new DataTable();
            adapter.Fill(dt);
            peopleDataGrid.DataContext = dt.DefaultView;
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            DataRow newRow = dt.NewRow();
            EditWindow editWindow = new EditWindow(newRow);
            editWindow.ShowDialog();
            if (editWindow.DialogResult.HasValue && editWindow.DialogResult.Value)
            {
                dt.Rows.Add(editWindow.resultRow);
                adapter.Update(dt);
            }
        }
        private void updateButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView newRow = (DataRowView)peopleDataGrid.SelectedItem;
            if (newRow == null)
                return;
            newRow.BeginEdit();
            EditWindow editWindow = new EditWindow(newRow.Row);
            editWindow.ShowDialog();
            if (editWindow.DialogResult.HasValue && editWindow.DialogResult.Value)
            {
                newRow.EndEdit();
                adapter.Update(dt);
            }
            else
            {
                newRow.CancelEdit();
            }
        }
        private void deleteButton_Click(object sender, RoutedEventArgs e)
        {
            DataRowView newRow = (DataRowView)peopleDataGrid.SelectedItem;
            if (newRow == null)
                return;
            newRow.Row.Delete();
            adapter.Update(dt);
        }
    }
}
