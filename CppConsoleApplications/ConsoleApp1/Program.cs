using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Element
    {
        private string fio;
        private int ball;
        public Element(string fio, int ball)
        {
            this.fio = fio;
            this.ball = ball;
        }
        public string FIO => fio;
        public int Ball => ball;
    }

    class Program
    {
        static int MyDelegat(Element el1, Element el2)
        {
            if (el1.Ball>el2.Ball) return 1;
            if (el1.Ball<el2.Ball) return -1;
            return 0;
        }
        static void Main()
        {
            List<Element> list = new List<Element>();
            using (StreamReader sr = new StreamReader("data.txt"))
            {
                int n=int.Parse(sr.ReadLine() ?? throw new InvalidOperationException());
                for (int i=0; i<n; i++)
                {
                    string[] s=sr.ReadLine()?.Split(' ');
                    int ball=int.Parse(s[2])+int.Parse(s[3])+int.Parse(s[4]);
                    list.Add(new Element(s[0]+" "+s[1],ball));
                }
            }
            list.Sort(MyDelegat);
            foreach (var v in list)
            {
                Console.WriteLine($"{v.FIO,20}{v.Ball,10}");
            }
            Console.WriteLine();
            int ball2=list[2].Ball;
            foreach (var v in list)
            {
                if (v.Ball<=ball2)
                    Console.WriteLine($"{v.FIO,20}{v.Ball,10}");
            }
            Console.ReadKey();
        }
    }
}
