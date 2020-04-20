using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            ChildWindow childWindow = new ChildWindow();
            childWindow.ViewModel = "Дчернее окно";
            childWindow.Owner = this;
            childWindow.Show();
            childWindow.ShowViewModel();
            foreach (Window win in this.OwnedWindows)
            {
                win.Background = new SolidColorBrush(Colors.Aquamarine);
                if (win is ChildWindow)
                    win.Title = "Новый заголовок";
            }
        }
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            foreach (Window win in App.Current.Windows)
            {
                win.Background = new SolidColorBrush(Colors.LightGreen);
            }
        }
    }


}
