using System;

/*5. Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от -100 до 100. 
 * Определить сумму элементов массива, расположенных между минимальным и максимальным элементами.*/

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int size = 5;
            int sum = 0;
            int[,] array = new int[size, size];
            int min = int.MaxValue,
                max = int.MinValue;
            int iMin = 0, jMin = 0,
                iMax = 0, jMax = 0;
            int i, j;
            Console.WriteLine("Random array of ints from -100  to 100 is:");
            for (i = 0; i < size; i++)
            {
                for (j = 0; j < size; j++)
                {
                    array[i, j] = rnd.Next(-100, 100);
                    if (max < array[i, j])
                    {
                        max = array[i, j];
                        iMax = i;
                        jMax = j;
                    }
                    if (min > array[i, j])
                    {
                        min = array[i, j];
                        iMin = i;
                        jMin = j;
                    }
                    Console.Write("{0,-4} ", array[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine("Min = {0,3} in array[{2},{3}], max = {1,3} in array[{4},{5}].", min, max, iMin, jMin, iMax, jMax);
            int iStart = 0, iEnd = 0,
               jStart = 0, jEnd = 0;
            if (iMin != iMax)
            {
                if (iMin < iMax)
                {
                    iStart = iMin; iEnd = iMax;
                    jStart = jMin; jEnd = jMax;
                }
                else
                {
                    iStart = iMax; iEnd = iMin;
                    jStart = jMax; jEnd = jMin;
                }
                i = iStart;
                for (j = jStart + 1; j < size; j++)
                    sum += array[i, j];
                for (i = iStart + 1; i < iEnd; i++)
                    for (j = 0; j < size; j++)
                        sum += array[i, j];
                for (j = 0; j < jEnd; j++)
                    sum += array[i, j];
            }
            else
            {
                if (jMin < jMax)
                {
                    jStart = jMin;
                    jEnd = jMax;
                }
                else
                {
                    jStart = jMax;
                    jEnd = jMin;
                }
                for (j = jStart + 1; j < jEnd; j++)
                {
                    sum += array[iMin, j];
                }
            }
            Console.WriteLine("Sum between minimal and maximal elements is {0}", sum);
        }
    }
}
