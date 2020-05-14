using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public enum State //текущее состояние работника
    {
        Work,
        Free,
    }
    public abstract class Person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Salary { get; set; }
        protected State state = State.Free;
        public State CurrState => state;
        public abstract void AddSalary();
        public Person() { }
        public Person(string name, int age, int salary)
        {
            Name = name;
            Age = age;
            Salary = salary;
        }
    }
}
