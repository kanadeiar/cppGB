using System;
using System.Runtime.Remoting.Contexts;
using System.Threading;

namespace ConsoleApp1
{
    class Program
    {
        class MyClass
        {
            public int A { get; set; }
            public int B { get; set; }
            public MyClass(int a, int b)
            {
                this.A = a;
                this.B = b;
            }
        }
        public static void Main()
        {
            Console.WriteLine($"Работа Main() в потоке {Thread.CurrentThread.Name}");
            MyClass myClass = new MyClass(2,2);
            WaitCallback workItem = new WaitCallback(MyPrint); 
            for (int i = 0; i < 10; i++)
                ThreadPool.QueueUserWorkItem(workItem, myClass); //запуск метода в очередь 10 раз
            Console.WriteLine("Нажать кнопку для завершения всех потоков");
            Console.ReadLine();
        }
        static void MyPrint(object data)
        {
            if (data is MyClass myClass)
            {
                for (int i = 0; i < 20; i++)
                {
                    Console.WriteLine($"Поток {Thread.CurrentThread.Name}: {myClass.A} + {myClass.B} = {myClass.A + myClass.B}");
                    myClass.A++;
                    Thread.Sleep(1000);
                }
            }
        }

    }
}
