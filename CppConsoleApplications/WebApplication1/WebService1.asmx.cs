using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebService1 : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld()
        {
            return "Привет всем!";
        }
        [WebMethod]
        public string Summ(string number1, string number2)
        {
            float a,b;
            bool f1 = float.TryParse(number1,out a);
            if (f1 == false) return "В первом поле должно быть число";
            bool f2 = float.TryParse(number2,out b);
            if (f2 == false) return "Во втором поле должно быть число";
            return "Сумма: " + (a+b).ToString();
        }
    }
}
