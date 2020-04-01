using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Vector
    {
        public double X {get; private set;}
        public double Y {get; private set;}
        public Vector()
        {
            X = Y = 0;
        }
        public Vector(double x, double y)
        {
            X = x;
            Y = y;
        }
    }
    
    class Program
    {
        static void Main(string[] args)
        {
            Vector v1 = new Vector(10,5);
            Console.WriteLine($"x={v1.X} y={v1.Y}");
            Console.ReadKey();
        }
    }
}
