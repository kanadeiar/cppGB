using System;
using System.Collections.Generic;
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

namespace WpfApp1HelloWPF
{
    /// <summary>
    /// Логика взаимодействия для EditWindow.xaml
    /// </summary>
    public partial class EditWindow : Window
    {
        public DataRow resultRow {get;set;}
        public EditWindow(DataRow dataRow)
        {
            InitializeComponent();
            resultRow = dataRow;
        }
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            fioTextBox.Text = resultRow["FIO"].ToString();
            birthdayTextBox.Text = resultRow["Birthday"].ToString();
            emailTextBox.Text = resultRow["Email"].ToString();
            phoneTextBox.Text = resultRow["Phone"].ToString();
        }
        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            resultRow["FIO"] = fioTextBox.Text;
            resultRow["Birthday"] = birthdayTextBox.Text;
            resultRow["Email"] = emailTextBox.Text;
            resultRow["Phone"] = phoneTextBox.Text;
            DialogResult = true;
        }
        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            DialogResult = false;
        }
    }
}
