using System;
using System.Diagnostics;
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
        private CancellationTokenSource cancelToken = new CancellationTokenSource(); //для отмены операции
        public MainWindow()
        {
            InitializeComponent();
        }
        private void CmdProcess_OnClick(object sender, RoutedEventArgs e)
        {
            Task.Factory.StartNew(() => ProcessFiles()); //вызов метода во вторичном потоке
        }
        private void ProcessFiles()
        {
            ParallelOptions parOpts = new ParallelOptions(); //опции для хранения токена отмены операции
            parOpts.CancellationToken = cancelToken.Token;
            parOpts.MaxDegreeOfParallelism = Environment.ProcessorCount;

            string[] files = Directory.GetFiles(@".\Test", "*.jpg",SearchOption.AllDirectories);
            string newDir = @".\MidifiedTest";
            Directory.CreateDirectory(newDir);

            try //отмена оперции путем отслеживания исключения
            {
                Parallel.ForEach(files, parOpts, curr =>
                {
                    parOpts.CancellationToken.ThrowIfCancellationRequested(); //исключение если отмена операции

                    string filename = Path.GetFileName(curr);
                    using (Bitmap bitmap = new Bitmap(curr))
                    {
                        bitmap.RotateFlip(RotateFlipType.Rotate180FlipNone);
                        bitmap.Save(Path.Combine(newDir, filename));
                        //this.Title = $"Выполенено {filename} в потоке {Thread.CurrentThread.ManagedThreadId}"; //не работает в многопоточной среде
                        Thread.Sleep(1000);
                        this.Dispatcher.Invoke(() => Debug.WriteLine($"Выполнено {filename}")); //безопасное в отношении потоков обновление интерфейса
                    }
                });
                this.Dispatcher.Invoke(() => this.Title = $"Все Выполнено!"); //безопасное в отношении потоков обновление интерфейса
            }
            catch (OperationCanceledException ex)
            {
                this.Dispatcher.Invoke(() => Debug.WriteLine(ex.Message));
            }
        }
        private void CmdCancel_OnClick(object sender, RoutedEventArgs e)
        {
            cancelToken.Cancel(); //для отмены операции
        }
    }
}
