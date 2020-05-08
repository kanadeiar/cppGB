using System;
using System.Collections.Generic;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfApp1WCFClient
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();
            try
            {
                int day = Convert.ToInt32(dayTextBox.Text);
                int month = Convert.ToInt32(monthTextBox.Text);
                int year = Convert.ToInt32(yearTextBox.Text);
                resultTextBlock.Text = "Дней: " + service.CalculateDays(day,month,year);
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Ошибка!\n"+ex.Message);
            }
        }
    }
}
