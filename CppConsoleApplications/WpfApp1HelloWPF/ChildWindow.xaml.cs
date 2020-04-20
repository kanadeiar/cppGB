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
using System.Windows.Shapes;

namespace WpfApp1HelloWPF
{
    /// <summary>
    /// Логика взаимодействия для ChildWindow.xaml
    /// </summary>
    public partial class ChildWindow : Window
    {
        public ChildWindow()
        {
            InitializeComponent();
        }
        public string ViewModel {get;set;}
        public void ShowViewModel()
        {
            textBlock.Text = ViewModel;
        }
        private void myButton_Click(object sender, RoutedEventArgs e)
        {
            this.Owner.Title = "Измененный заголовок";
        }
    }
}
