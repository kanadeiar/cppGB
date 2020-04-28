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
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using System.ComponentModel;

namespace WpfApp1HelloWPF
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private ObservableCollection<User> users = new ObservableCollection<User>();
        public MainWindow()
        {
            InitializeComponent();
            users.Add(new User{Name = "Петя"});
            users.Add(new User{Name = "Коля"});
            listBoxUsers.ItemsSource = users;
        }

        private void buttonAddUser_Click(object sender, RoutedEventArgs e)
        {
            users.Add(new User{Name = "Вася"});
        }

        private void buttonChangeUser_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
                (listBoxUsers.SelectedItem as User).Name = "Иван";
        }

        private void buttonDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            if (listBoxUsers.SelectedItem != null)
                users.Remove(listBoxUsers.SelectedItem as User);
        }
    }
    public class User : INotifyPropertyChanged
    {
        private string name;
        public string Name
        {
            get => name;
            set
            {
                if (name != value)
                {
                    name = value;
                    NotifyPropertyChanged("Name");
                }
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        public void NotifyPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
