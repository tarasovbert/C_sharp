using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book(1, "War and peace", 2.6);
            using (FileStream file = new FileStream("file.txt", FileMode.Create))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                binFormat.Serialize(file, book);
            }

            Book openBook;   // десериализация объекта   
            using (FileStream file = new FileStream("file.txt", FileMode.Open))
            {
                BinaryFormatter binFormat = new BinaryFormatter();
                openBook = (Book)binFormat.Deserialize(file);
            }


            Console.WriteLine(openBook);
            Console.ReadKey(true);
        }

    }

    [Serializable]
    class Book
    {
        int id;
        string name;
        double price;

        public Book(int ID, string Name, double Price)
        {
            id = ID; name = Name; price = Price;
        }
        public override string ToString()
        {
            return string.Format("{0}.{1},{2}", id, name, price);
        }
    }

}

