using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Объявить одномерный(5 элементов ) массив с именем A и двумерный массив(3 строки, 4 столбца) дробных чисел с именем B.
//Заполнить одномерный массив А числами, введенными с клавиатуры пользователем, а двумерный массив В случайными числами с помощью циклов.
//Вывести на экран значения массивов: массива А в одну  строку, массива В – в виде матрицы.Найти в данных массивах максимальный элемент,
//общий минимальный элемент, сумму всех элементов, произведение всех элементов, сумму четных элементов массива А, сумму нечетных столбцов массива В.

namespace Task1a
{
    class Program
    {
        static void Main(string[] args)
        {
            int length1 = 5;
            double[] A = new double[length1];
            decimal aComp = 1;
            double aEvenSum = 0;
            Console.WriteLine("Enter doubles to array A: ");
            for (int i = 0; i < length1; i++)
            {
                A[i] = double.Parse(Console.ReadLine());
                aComp *= (decimal)A[i];
                if ((i) % 2 == 0)
                    aEvenSum += A[i];
            }
            Console.WriteLine(Environment.NewLine + "Array A is: ");
            for (int i = 0; i < length1; i++)
                Console.Write(A[i] + " ");
            Console.WriteLine(Environment.NewLine);

            int length2 = 3;
            int length3 = 4;
            double[,] B = new double[length2, length3];
            Random rnd = new Random();
            Console.WriteLine("Array B is: ");
            double bMax = double.MinValue;
            double bMin = double.MaxValue;
            double bSum = 0;
            decimal bComp = 1;
            double bSumOddColumns = 0;
            for (int i = 0; i < length2; i++)
            {
                for (int j = 0; j < length3; j++)
                {
                    B[i, j] = rnd.NextDouble() * 10;//from 0.0 to 10.0
                    if (bMax < B[i, j])
                        bMax = B[i, j];
                    if (bMin > B[i, j])
                        bMin = B[i, j];
                    bSum += B[i, j];
                    bComp *= (decimal)B[i, j];
                    if (j % 2 == 0)
                        bSumOddColumns += B[i, j];
                    Console.Write("{0:f4} ", B[i, j]);
                }
                Console.WriteLine();
            }
            Console.WriteLine(Environment.NewLine + "Array's A maximal element is: {0:f4}.", A.Max());
            Console.WriteLine("Array's B maximal element is: {0:f4}.", bMax);
            Console.WriteLine("Minimal element of both arrays is: {0:f4}.", A.Min() < bMin ? A.Min() : bMin);
            Console.WriteLine("Sum of all elemeints of both arrays is: {0:f4}.", A.Sum() + bSum);
            Console.WriteLine("Composition of all elemeints of both arrays is: {0:f4}.", aComp * bComp);
            Console.WriteLine("Sum of even elements of A array is {0:f4}", aEvenSum);
            Console.WriteLine("Sum of elements of odd columns of B array is {0:f4}", bSumOddColumns);
        }
    }
}
