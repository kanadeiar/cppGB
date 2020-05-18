using System;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Windows.Forms;

using MySnappableTypes;
namespace ConsoleApp1
{
    class Program
    {
        [STAThread]
        public static void Main()
        {
            try
            {
                LoadSnapIn();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
            Console.ReadLine();
        }
        static void LoadSnapIn()
        {
            OpenFileDialog dlg = new OpenFileDialog
            {
                InitialDirectory = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location),
                Filter = "Assemblies (*.dll)|*.dll|All files (*.*)|*.*",
                FilterIndex = 1,
            };
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                if (dlg.FileName.Contains("MySnappableTypes"))
                    Console.WriteLine("В библиотеке нет оснасток!");
                else if (!LoadExternalModule(dlg.FileName))
                    Console.WriteLine("Не включает интерфейс IAppFunctionality");
            }
        }

        static bool LoadExternalModule(string path)
        {
            bool foundSnapIn = false;
            Assembly asm = null;
            try
            {
                asm = Assembly.LoadFrom(path);
            }
            catch (Exception e)
            {
                Console.WriteLine($"Ошибка загрузки оснастки: {e.Message}");
                return foundSnapIn;
            }
            var theClassTypes = asm.GetTypes()
                .Where(t => t.IsClass && t.GetInterface("IAppFunctionality") != null)
                .Select(t => t); //получить все классы совместимые с интерфейсом IAppFunctionality
            foreach (var t in theClassTypes)
            {
                foundSnapIn = true;
                var itfApp = asm.CreateInstance(t.FullName, true) as IAppFunctionality;
                itfApp?.DoIt();
                DisplaySnapInfo(t);
            }
            return foundSnapIn;
        }

        private static void DisplaySnapInfo(Type tp)
        {
            var compInfo = tp.GetCustomAttributes(false).Where(t => t is MyInfoAttribute).Select(t => t);
            foreach (var c in compInfo)
            {
                Console.WriteLine($"Информация о сборке: {(c as MyInfoAttribute)?.CompanyName}");
            }
        }

    }



}
