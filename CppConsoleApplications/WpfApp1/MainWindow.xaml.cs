using System;
using System.Drawing;
using System.IO;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;

namespace WpfApp1
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
        private void CmdCancel_OnClick(object sender, RoutedEventArgs e)
        {
            //
        }
        private void CmdProcess_OnClick(object sender, RoutedEventArgs e)
        {
            ProcessFiles();
        }
        private void ProcessFiles()
        {
            string[] files = Directory.GetFiles(@".\Test", "*.jpg",SearchOption.AllDirectories);
            string newDir = @".\MidifiedTest";
            Directory.CreateDirectory(newDir);

            Parallel.ForEach(files, curr =>
            {
                string filename = Path.GetFileName(curr);
                using (Bitmap bitmap = new Bitmap(curr))
                {
                    bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                    bitmap.Save(Path.Combine(newDir, filename));
                    //this.Title = $"Выполенено {filename} в потоке {Thread.CurrentThread.ManagedThreadId}";
                }
            });
            this.Title = "Выполнено!";
        }
    }
}
