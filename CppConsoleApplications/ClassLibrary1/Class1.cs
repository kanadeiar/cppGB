using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClassLibrary1
{
    [Serializable]
    [Obsolete("Старый класс!")]
    public class Class1
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public int Money { get; set; }
        public void GetSalary()
        {
            Money += 1000;
            MessageBox.Show($"Выполнение!\n{Money}");
        }
        public void SetAge(int age)
        {
            MessageBox.Show($"Выполнение!");
            Debug.WriteLine("111");
        }
    }
}
