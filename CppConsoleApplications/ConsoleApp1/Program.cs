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
        public delegate void Message(string message);
        private event Message message;
        private readonly List<string> user = new List<string>();
        public Source()
        {
            user.AddRange(new[] { "Ivan", "Roman", "Stepan" });
        }
        public void RemoveUser(string nameUser, Message message)
        {
            this.message = message;
            if (user.Contains(nameUser))
            {
                user.Remove(nameUser);
                this.message?.Invoke($"Пользователь {nameUser} удален");
            }
            else
            {
                this.message?.Invoke($"Пользователь {nameUser} не найден");
            }
        }
    }

    class Program
    {
        private static void Message(string message)
        {
            Console.WriteLine(message);
        }
        static void Main(string[] args)
        {
            Source source = new Source();
            source.RemoveUser("Ivan", Message);
            Console.ReadKey();
        }
    }
}
