using System;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        static Random r = new Random();
        class MyClass
        {
            private object thredLock = new object(); //маркер блокировки
            public void Print()
            {
                lock (thredLock) //использование маркера блокировки
                {
                    Console.WriteLine($"Поток \"{Thread.CurrentThread.Name}\" числа: ");
                    for (int i = 0; i < 10; i++)
                    {
                        Console.Write($"{i + 1},");
                        Thread.Sleep(1000 * r.Next(3));
                    }
                    Console.Write("конец\n");
                }
            }
        }
        public static void Main()
        {
            MyClass myClass = new MyClass();
            Thread[] threads = new Thread[10]; //10 потоков
            for (int i = 0; i < 10; i++)
            {
                threads[i] = new Thread(new ThreadStart(myClass.Print));
                threads[i].Name = $"Поток № {i+1}";
            }
            foreach (var th in threads)
                th.Start();
            Console.ReadLine();
        }

    }
}
