using System;
using System.Diagnostics;
using System.Linq;


namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Process myProc = null;
            try
            {
                ProcessStartInfo startInfo = new ProcessStartInfo("firefox.exe", "www.yandex.ru");
                startInfo.WindowStyle = ProcessWindowStyle.Maximized;
                myProc = Process.Start(startInfo);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return;
            }
            Console.WriteLine($"Нажмите клавишу для закрытия процесса '{myProc.ProcessName}'");
            Console.ReadKey();
            try
            {
                myProc.Kill();
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            Console.ReadLine();
        }
    }
}
