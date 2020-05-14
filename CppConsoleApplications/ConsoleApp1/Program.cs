using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

using ClassLibrary1;

namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Worker worker = new Worker("Вася",18,5000);
            worker.AddSalary();
            Manager manager = new Manager("Петя",20,10000);
            manager.AddSalary();
            Console.WriteLine("Нажмите любую кнопку");
            Console.ReadLine();
        }
    }
}
