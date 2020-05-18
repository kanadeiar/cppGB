using System;

using MySnappableTypes;
namespace MySnapIn
{
    [MyInfo(CompanyName = "MyTest")]
    class MyModule : IAppFunctionality
    {
        public void DoIt()
        {
            Console.WriteLine("Успешное подключение оснастки 'MyTest'!");
        }
    }
}
