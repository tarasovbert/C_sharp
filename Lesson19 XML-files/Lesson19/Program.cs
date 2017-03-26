using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Lesson19
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = @"http://www.nbrb.by/Services/XmlExRates.aspx";
            XDocument xmlDoc = XDocument.Load(url);
            int countCourse = xmlDoc.Root.Elements().Count();

            foreach(var item in xmlDoc.Root.Elements())
            {
                string info = String.Format("Currency: {0} - {1}. Scale: {2,-6:N2} to {3,6} {4}",
                    item.Element("NumCode").Value,
                    item.Element("CharCode").Value,
                    item.Element("Scale").Value,
                    item.Element("Rate").Value, 
                    item.Element("Name").Value);
            Console.WriteLine(info);
            }
            Console.ReadKey();

            
                }
    }
}
