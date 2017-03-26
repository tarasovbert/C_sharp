using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WeaterGetter
{
    public class Getter
    {
        string url = @"https://pogoda.yandex.ru/static/cities.xml";

        public void MakeXML()
        {
            XDocument xmlDoc = XDocument.Load(url);
            int quantity = xmlDoc.Root.Elements().Count();
        }
       
    }
}
