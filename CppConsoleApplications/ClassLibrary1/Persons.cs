using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using System.Windows.Forms;
namespace ClassLibrary1
{
    public class Worker : Person //работник
    {
        public Worker() { }
        public Worker(string name, int age, int salary) 
            : base(name, age, salary) { }
        public override void AddSalary() //прибавка зарплаты
        {
            Salary += 100;
            MessageBox.Show($"Получение зарплаты {Salary}");
        }
    }
    public class Manager : Person //менеджер
    {
        public Manager() { }
        public Manager(string name, int age, int salary) 
            : base(name, age, salary) { }
        public override void AddSalary() //прибавка зарплаты
        {
            Salary += 10000;
            MessageBox.Show($"Получение бонуса {Salary}!");
        }
    }
}
