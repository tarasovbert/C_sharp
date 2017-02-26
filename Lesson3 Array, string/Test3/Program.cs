using System;
using System.Diagnostics;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//1.	Задача о максимальном произведении трех чисел массива
//Задача, которую предлагали на собеседованиях в Apple: у вас есть массив с целыми числами, в том числе и отрицательными, 
//вам нужно найти самое большое произведение 3 чисел из этого массива.
//Например: у вас есть массив arrayInts, содержащий числа -10, -10, 1, 3, 2. Метод, который обрабатывает этот массив, должен вернуть 300, 
//так как  -10 * -10 * 3 = 300. 

namespace Task1b
{
    class Program
    {
        static void Main(string[] args)
        {
            var sw = new Stopwatch();
            Console.WriteLine(GC.GetTotalMemory(true));       
            sw.Start();
            int[] arrayInts = { -10, -10, 1, 3, 2 };
            int size = arrayInts.Length;          
            int max = arrayInts[0] * arrayInts[1]* arrayInts[2];
            for (int i = 0; i < size; i++)
                for (int j = i + 1; j < size; j++)
                    for (int k = j + 1; k < size; k++)                    
                        if (j != i && k != i && arrayInts[i] * arrayInts[j] * arrayInts[k] > max)
                            max = arrayInts[i] * arrayInts[j] * arrayInts[k];                    
            Console.WriteLine(max);
            Console.WriteLine(sw.ElapsedTicks);
            Console.WriteLine(GC.GetTotalMemory(true));
        }
    }
}
