using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    public struct User
    {
        public string FirstName {get;set;}
        public string LastName {get;set;}
        public int Age {get;set;}
        public User(string firstName, string lastName) : this()
        {
            FirstName = firstName;
            LastName = lastName;
        }
    }
    public class ExampleLinq
    {
        private readonly User[] users;
        private readonly int[] numbers;
        public ExampleLinq()
        {
            this.users = new[]
            {
                new User("Roman","Muratov"){Age = 18},
                new User("Ivan","Petrov"){Age = 22},
                new User("Igor","Ivanov"){Age = 26},
                new User("Sveta","Muratova"){Age = 16},
                new User("Lena","Ivanova"){Age = 36},
                new User("Leonid","Petrov"){Age = 25},
                new User("Max","Muratov"){Age = 20},
            };
            this.numbers = new[]{1,2,3,4,9,15};
        }
        public void Filter()
        {
            var evens = numbers.Where(i=>i%2==0 && i>6);
            foreach (var el in evens)
                Console.WriteLine(el);
        }
        public void SelectComplex()
        {
            var selectUsers = from user in users
                              where user.Age>20
                              select user;
            var selUsr1 = selectUsers.ToList();
            foreach (var el in selUsr1)
                Console.WriteLine($"{el.FirstName} - {el.LastName}");
        }
        public void Projection()
        {
            var names = users.Select(u => u.FirstName).ToList();
            foreach (var user in names)
                Console.WriteLine(user);
        }
        public void ExampleLet()
        {
            var people = from u in users
                         let age = u.Age <= 18 ? u.Age + (18-u.Age) : u.Age
                         select new User(u.FirstName, u.LastName)
                         {
                             Age = age
                         };
            foreach (var user in people)
                Console.WriteLine($"{user.FirstName}-{user.LastName}");
        }
        public void SamplingFromTwo()
        {
            var people = from user in users
                         from num in numbers
                         select new {Name=user.LastName,Number=num};
            foreach (var p in people)
                Console.WriteLine($"{p.Name}-{p.Number}");
        }
        public void Sorting()
        {
            var sortedUsers = from u in users
                              orderby u.Age
                              select u;
            foreach (var u in sortedUsers)
                Console.WriteLine($"{u.FirstName}-{u.Age}");
        }
        public void WorkingWithSets()
        {
            string[] peopleOne = {"Igor","Roman","Ivan"};
            string[] peopleTwo = {"Roman","Ivanovo","Den"};
            var result1 = peopleOne.Except(peopleTwo);
            var result2 = peopleOne.Intersect(peopleTwo);
            var result3 = peopleOne.Union(peopleTwo);
            var result4 = peopleOne.Concat(peopleTwo).Distinct();
            foreach (var el in result1)
                Console.Write($"{el} ");
            Console.WriteLine();
            foreach (var el in result2)
                Console.Write($"{el} ");
            Console.WriteLine();
            foreach (var el in result3)
                Console.Write($"{el} ");
            Console.WriteLine();
            foreach (var el in result4)
                Console.Write($"{el} ");
            Console.WriteLine();
        }
        public void Average()
        {
            double avr1 = numbers.Average();
            Console.WriteLine($"{avr1}");
            var arr1=(from i in numbers select i).Take(2);
            foreach (var el in arr1)
                Console.WriteLine($"{el}");
            var arr2=(from i in numbers select i).Skip(2);
            foreach (var el in arr2)
                Console.WriteLine($"{el}");
        }
        public void Group()
        {
            //var groups = from user in users
            //             group user by user.LastName;
            //foreach (var g in groups)
            //{
            //    Console.Write($"{g.Key}: ");
            //    foreach (var t in g)
            //        Console.Write($"{t.FirstName} {t.Age} ");
            //    Console.WriteLine();
            //}
            var group1 = users.GroupBy(p=>p.LastName)
                .Select(g=>new
                {
                    Family = g.Key,
                    Count = g.Count(),
                    Names = g.Select(p=>p),
                });
            foreach (var el in group1)
            {
                Console.Write($"{el.Family} {el.Count} шт.: ");
                foreach (var t in el.Names)
                    Console.Write($"{t.FirstName} ");
                Console.WriteLine();
            }

        }



    }


    class Program
    {
        public static void Main()
        {
            ExampleLinq exampleLinq = new ExampleLinq();
            exampleLinq.Group();



            Console.ReadKey();
        }
    }
}
