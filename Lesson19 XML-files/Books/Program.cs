using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Books
{
    class Program
    {
        static void Main(string[] args)
        {
            XDocument booksStore = new XDocument();
            booksStore = XDocument.Load("Bookstore.xml");
            Console.WriteLine(booksStore.Document);
            string info;
            string info2;
            

            foreach (var item in booksStore.Root.Elements())
            {
                XNode node = booksStore.Document;
                info = String.Format("author: {0}",
                    item.Element("author").Value);
                Console.WriteLine(info);
                

            }

        }
    }
}
