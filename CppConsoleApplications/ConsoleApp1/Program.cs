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
        public void Deconstruct(out string firstName, out string lastName, out int age)
        {
            firstName = FirstName;
            lastName = LastName;
            age = Age;
        }
    }


    class Program
    {
        public static void Main()
        {
            User person = new User("Andrey","Muratov") {Age=18};
            (string fname, string lname, int age) = person;
            Console.WriteLine($"{fname}\n{lname}\n{age}");



            Console.ReadKey();
        }
    }
}
