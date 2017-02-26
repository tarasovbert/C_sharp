using System;

/*6. Дан двумерный массив размерностью 5х5, заполненный случайными числами из диапазона от 0 до 100.
Найти максимальные элементы каждого столбца.*/
namespace Task6
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
            Console.WriteLine(Environment.NewLine + "Sums of elements of columns are:");
            for (j = 0; j < size; j++)
            {
                sum = 0;
                for (i = 0; i < size; i++)
                {
                    sum += array[i, j];
                }
                Console.Write("{0,-4} ", sum);
            }
            Console.WriteLine();
        }
    }
}
