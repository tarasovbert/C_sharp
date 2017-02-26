using System;

/*7. Заполнить квадратную матрицу размером N x N по спирали(N – нечётное число). Число 1 ставится в центр матрицы, 
а затем массив заполняется по спирали против часовой стрелки значениями по возрастанию.*/

namespace Task7
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 5;
            int[,] array = new int[size, size];
            int step = 1;
            int value = 1;           
            int i = size / 2;
            int j = size / 2;
            array[i, j] = value++;

            while (step <= size && i < size && i >= 0 && j < size && j >= 0)
            {
                goUp(ref i, ref j, ref step, ref value, ref array);
                if (step == size) break;
                goRight(ref i, ref j, ref step, ref value, ref array);
                goDown(ref i, ref j, ref step, ref value, ref array);
                goLeft(ref i, ref j, ref step, ref value, ref array);
            }
                PrintArray(array, size);
        }

        private static void goUp(ref int i, ref int j, ref int step, ref int value, ref int[,] array)
        {
            int bound = i - step;
            while (i > 0 && i > bound)
                array[--i, j] = value++;
        }

        private static void goRight(ref int i, ref int j, ref int step, ref int value, ref int[,] array)
        {
            int bound = j + step;
            while (j < bound)
                array[i, ++j] = value++;
            step++;
        }

        private static void goDown(ref int i, ref int j, ref int step, ref int value, ref int[,] array)
        {
            int bound = i + step;
            while (i < bound)
                array[++i, j] = value++;
        }

        private static void goLeft(ref int i, ref int j, ref int step, ref int value, ref int[,] array)
        {
            int bound = j - step;
            while (j > bound)
                array[i, --j] = value++;
            step++;
        }

        private static void PrintArray(int[,] array, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {

                    Console.Write("{0,-4} ", array[i, j]);
                }
                Console.WriteLine(Environment.NewLine);
            }
        }
    }
}
