using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lesson4
{
    class Car
    {
        #region FIELDS
        int id1;
        private string name;
        #endregion

        #region PROPERTIES
        public int Id
        {
            get{ return id1;}
            set{id1 = value;}
        }

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        #endregion




        public Car()
        {
            Radio d = new Radio();
        }


        public bool IdUp()
        {
            id1++;
            return true;
        }


        /// <summary>
        /// Test method
        /// </summary>
        /// <param name="name">Name of human</param>
        /// <param name="price">Price of human</param>
        /// <returns>Quantity of humans</returns>
        public int Method (string name, decimal price)
        {
            int N = 100;
            PrintNumbers(N);
            return 0;
        }

        private static void PrintNumbers(int N)
        {
            for (int i = 0; i < N; i++)
            {
                Console.WriteLine(i);
            }
        }
    }
}
