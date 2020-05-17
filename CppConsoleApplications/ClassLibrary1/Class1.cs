using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary1
{
    public class Class1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }
        public void GetSalary()
        {
            Money += 1000;
        }
    }
}
