using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Configuration;
using System.IO;
using System.Reflection;
using System.Threading.Tasks;



namespace ConsoleApp1
{
    class Program
    {
        public static void Main()
        {
            Assembly a = null;
            try
            {
                a = Assembly.Load("ClassLibrary1");
            }
            catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message); Console.ReadLine();
                return;
            }
            if (a != null)
            {
                try
                {
                    var myClass = a.GetType("ClassLibrary1.Class1");
                    var obj = Activator.CreateInstance(myClass);
                    var mi = myClass.GetMethod("SetAge");
                    mi.Invoke(obj, new object[]{19});
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message); Console.ReadLine();
                    return;
                }
            }
            Console.ReadLine();
        }
    }
}
