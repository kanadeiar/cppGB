using System;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Messaging;
using System.Threading;

namespace ConsoleApp1
{
    public delegate int MySample(int x, int y);
    class Program
    {
        private static bool isDone = false;
        public static void Main()
        {
            Console.WriteLine($"Main() запущен в потоке: {Thread.CurrentThread.ManagedThreadId}");
            MySample mySmp = new MySample(Add);
            //IAsyncResult asyncRes = mySmp.BeginInvoke(10, 10, null, null); //без передачи делегата
            //IAsyncResult asyncRes = mySmp.BeginInvoke(10, 10, AddComplete, null); //передача делегата обратного вызова
            IAsyncResult asyncRes = mySmp.BeginInvoke(10, 10, AddComplete, "Привет шахтерам!"); //передача делегата обратного вызова и данных
            while (!isDone)
            {
                Console.WriteLine("Ожидание выполнения в Main()");
                Thread.Sleep(1000);
            }
            Console.ReadLine();
            int Add(int x, int y)
            {
                Console.WriteLine($"Add() запущен в потоке {Thread.CurrentThread.ManagedThreadId}");
                Thread.Sleep(5000);
                return x + y;
            }
            void AddComplete(IAsyncResult iar)
            {
                Console.WriteLine($"Add() завершен в потоке {Thread.CurrentThread.ManagedThreadId}");
                AsyncResult ar = (AsyncResult)iar;
                MySample tmp = (MySample)ar.AsyncDelegate;
                int answer = tmp.EndInvoke(ar);
                Console.WriteLine($"Результат: 10 + 10 = {answer}");
                string msg = (string) iar.AsyncState; //сообщение
                Console.WriteLine(msg); //сообщение
                isDone = true;
            }
        }
    }
}
