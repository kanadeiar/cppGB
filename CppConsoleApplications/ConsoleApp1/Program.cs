using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;



using System.Configuration;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Run();
            Console.ReadLine();
            async void Run()
            {
                while (true)
                {
                    Console.WriteLine("Text Text Текст Текст");
                    await Task.Delay(1000);
                }
            }
        }


    }
}
