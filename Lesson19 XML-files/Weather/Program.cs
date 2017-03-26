using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Weather
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"https://pogoda.yandex.ru/static/cities.xml";
            XDocument xmlDoc = XDocument.Load(url);
            int quantity = xmlDoc.Root.Elements().Count();
            Console.WriteLine(quantity);


        }
    }
}
