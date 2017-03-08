using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Исходные данные: массив с числами типа int. Вам нужно написать метод, который на входе получит исходный массив, 
а на выходе вернет массив, в котором каждое значение получено путем произведения всех значений
исходного массива с отличным от текущего индексом.
Для ясности - пример. Исходный массив имеет вид:
[1, 7, 3, 4]
Тогда функция должна вернуть:
[84, 12, 28, 21]
Расчет значений происходит следующим образом:
[7*3*4, 1*3*4, 1*7*4, 1*7*3]*/


namespace Task2b
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] initialArray = new int[] { 1, 7, 4, 3};
            int length = initialArray.Length;
            long composition;
            long[] derivativeArray = new long[length];
            for (int i = 0; i < length; i++)
            {
                composition = 1;
                for (int j = 0; j < length; j++)
                {
                    if (j == i) continue;
                    composition *= initialArray[j];
                }
                derivativeArray[i] = composition;
            }
            for (int i = 0; i < length; i++)
                Console.Write(derivativeArray[i] + " ");
            Console.WriteLine();
        }
    }
}
