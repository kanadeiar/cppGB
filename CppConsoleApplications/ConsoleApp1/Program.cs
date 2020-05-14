using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;

namespace ConsoleApp1
{


    class Program
    {
        class MyClass
        {
            private Lazy<String> name = new Lazy<String>(() => "новая строка");
            public String GetName()
            {
                return name.Value; //значение с отложенной инициализацией
            }
        }
        public static void Main()
        {
            MyClass my = new MyClass();
            Console.WriteLine(my.GetName()); //здесь размещение объекта в памяти
            Console.ReadLine();
        }

    }
}
