using System;
using System.Collections.Generic;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.Serialization.Formatters.Soap;
using System.Text;
using System.Xml.Serialization;


namespace ConsoleApp1
{
    [Serializable]
    class MyData
    {
        private string name = "имя";
        private double money = 1_000_000.0;
        public MyData(){}
        [OnSerializing]
        private void OnSerializing(StreamingContext context)
        {
            name = name.ToUpper();
            money = money / 1_000.0;
        }
        [OnDeserialized]
        private void OnDeserialized(StreamingContext context)
        {
            name = name.ToUpper();
            money = money * 1_000.0;
        }
        public (string name, double money) Deconstruct() => (name, money);
    }
    #region Classes
    [Serializable]
    public class Person
    {
        public string Name { get; set; }
        [XmlAttribute]
        public int Age { get; set; } //дополнительно кодирование как атрибута
        [NonSerialized] 
        public string Secret = "XF-1244";
        public Person() {} //для xml сериализации
    }
    [Serializable]
    public class Home
    {
        public Person Person { get; set; }
        public int Size { get; set; }
        public Home() {} //для xml сериализации
    }
    [Serializable] //специальное уточнение пространства имен XML
    public class BigHome : Home
    {
        public int Count { get; set; }
        public BigHome() {} //для xml сериализации
    }
    #endregion
    class Program
    {
        static void Main()
        {
            //SaveListToXml();
            //ReadNPrintListFromXml();
            MyData myData = new MyData();
            SoapFormatter soapFormatter = new SoapFormatter();
            using (FileStream fs = new FileStream("mydata.soap",FileMode.Create,FileAccess.Write,FileShare.None))
            {
                soapFormatter.Serialize(fs, myData);
            }
            using (FileStream fs = File.OpenRead("mydata.soap"))
            {
                myData = soapFormatter.Deserialize(fs) as MyData;
                var (n, m) = myData.Deconstruct();
                Console.WriteLine($"Прочитанные данные: {n} {m}");
            }
            Console.WriteLine("Нажмите любую кнопку для выхода...");
            Console.ReadKey();
            #region XML
            //void SaveListToXml()
            //{
            //    List<BigHome> myHomes = new List<BigHome>();
            //    myHomes.Add(new BigHome
            //    {
            //        Person = new Person
            //        {
            //            Name = "Тестовое имя",
            //            Age = 22,
            //        },
            //        Size = 10,
            //        Count = 1,
            //    });
            //    myHomes.Add(new BigHome
            //    {
            //        Person = new Person
            //        {
            //            Name = "Дополнительное имя",
            //            Age = 18,
            //        },
            //        Size = 15,
            //        Count = 3,
            //    });
            //    myHomes.Add(new BigHome
            //    {
            //        Person = new Person
            //        {
            //            Name = "Третье имя",
            //            Age = 32,
            //        },
            //        Size = 30,
            //        Count = 2,
            //    });
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BigHome>));
            //    using (FileStream stream = new FileStream("list.xml",FileMode.Create,FileAccess.Write,FileShare.None))
            //    {
            //        xmlSerializer.Serialize(stream, myHomes);
            //    }
            //    Console.WriteLine("Объект сохранен в Xml формате...");
            //}
            //void ReadNPrintListFromXml()
            //{
            //    XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<BigHome>));
            //    using (FileStream stream = new FileStream("list.xml",FileMode.Open,FileAccess.Read,FileShare.None))
            //    {
            //        List<BigHome> myHomes = xmlSerializer.Deserialize(stream) as List<BigHome>;
            //        Console.WriteLine("Прочитанный список:");
            //        foreach (var m in myHomes)
            //            Console.WriteLine($"Прочитанный объект: {m.Person.Name}, {m.Person.Age}, {m.Size}, {m.Count}");
            //    }
            //}
            #endregion
        }
    }
}
