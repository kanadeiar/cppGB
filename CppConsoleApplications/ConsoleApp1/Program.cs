using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    public delegate void MyDelegate(object o);
    class Source
    {
        MyDelegate functions;
        public void Add(MyDelegate f)
        {
            functions += f;
        }
        public void Remove(MyDelegate f)
        {
            functions -= f;
        }
        public void Run()
        {
            Console.WriteLine("RUN!");
            functions?.Invoke(this);
        }
    }
    class Observer1
    {
        public void Do(object o)
        {
            Console.WriteLine($"Первый принял {o} побежал");
        }
    }
    class Observer2
    {
        public void Do(object o)
        {
            Console.WriteLine($"Второй принял {o} побежал");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Source s = new Source();
            Observer1 o1 = new Observer1();
            Observer2 o2 = new Observer2();
            MyDelegate d1 = new MyDelegate(o1.Do);
            s.Add(d1);
            s.Add(o2.Do);
            s.Run();
            s.Remove(o1.Do);
            s.Run();
            Console.ReadKey();
        }


    }
}
