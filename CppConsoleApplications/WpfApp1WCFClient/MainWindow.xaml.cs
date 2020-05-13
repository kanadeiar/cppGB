using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net.Http;
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
        static HttpClient client;
        public MainWindow()
        {
            InitializeComponent();
            client = new HttpClient();
            client.BaseAddress = new Uri(@"https://localhost:44326/");
        }
        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var products = await GetProductsAsync(client.BaseAddress + "api/products");
            productDataGrid.ItemsSource = products;
        }
        static async Task<IEnumerable<Product>> GetProductsAsync(string path)
        {
            IEnumerable<Product> products = null;
            try
            {
                var response = await client.GetAsync(path);
                response.EnsureSuccessStatusCode();
                products = await response.Content.ReadAsAsync<IEnumerable<Product>>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка!"+ex.Message);
            }
            return products;
        }
    }
}
