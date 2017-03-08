using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartArray
{
    class Program
    {
    
        
        static void Main()
        {
            
            int indexLower;
            int indexUpper;
            int index;
            int value;
            
            Console.WriteLine("Enter the numbers to indexate array of ints: {0}First index: ", Environment.NewLine);

            while (!Int32.TryParse(Console.ReadLine(), out indexLower)) { }
            Console.Write("Second index: ");
            while (!Int32.TryParse(Console.ReadLine(), out indexUpper)) { }
            
            SmartArray smartArray = new SmartArray(indexLower, indexUpper);

            Console.WriteLine("The array will be filled with random integers. It is: ");
            for (int i = indexLower; i <= indexUpper; i++)
            {
                Console.Write("{0} ", smartArray[i]);
            }
            Console.WriteLine();

            
            index = GetElementByIndex(smartArray);
            value = SetValueByIndex(ref index, smartArray);
            Console.WriteLine("The array now is: ");
            for (int i = indexLower; i <= indexUpper; i++)
            {
                Console.Write("{0} ", smartArray[i]);
            }
            Console.WriteLine();
        }

        private static int GetElementByIndex(SmartArray smartArray)
        {
            Console.WriteLine("Enter the index to get element:");
            int index;
            while (!Int32.TryParse(Console.ReadLine(), out index)) { }
            try
            {
                Console.WriteLine(smartArray[index]);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
                GetElementByIndex(smartArray);
            }
            return index;
        }

        private static int SetValueByIndex(ref int index, SmartArray smartArray)
        {
            int value;
            Console.WriteLine("Enter the value to set element:");
            while (!Int32.TryParse(Console.ReadLine(), out value)) { }
            Console.WriteLine("Enter the index to set element:");
            while (!Int32.TryParse(Console.ReadLine(), out index)) { }
            try
            {
                smartArray[index] = value;
            }
            catch (IndexOutOfRangeException ex) { Console.WriteLine(ex.Message); }
            return value;
        }
    }
}


