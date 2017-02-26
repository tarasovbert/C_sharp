using System;

/*2.	Даны 2 массива размерности M и N соответственно. Необходимо переписать в третий массив
общие элементы первых двух массивов без повторений.*/

namespace Task2a
{
    class Program
    {
        static void Main(string[] args)
        {
            int consequences = 0;
            Console.Write("Enter the measure of 2 arrays of ints: " + Environment.NewLine + "M: ");
            int M = int.Parse(Console.ReadLine());
            Console.Write("N: ");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the elements of first array: ");
            int[] array1 = new int[M];
            for (int i = 0; i < M; i++)
            {
                array1[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("Enter the elements of second array: ");
            int[] array2 = new int[N];
            int[] array3 = new int[M < N ? M : N];
            bool zeroMet = false;
            int length3 = array3.Length;
            for (int i = 0; i < N; i++)
            {
                array2[i] = int.Parse(Console.ReadLine());
                for (int j = 0; j < M; j++)
                {
                    if (array2[i] == array1[j])
                    {
                        int k;
                        for (k = 0; k < length3; k++)
                        {
                            if (array3[k] == array2[i] && array2[i] != 0 
                                || (array2[i] == 0 && zeroMet == true)) break;
                        }
                        if (k == length3)
                        {
                            if (array2[i] == 0 && zeroMet == false)
                                zeroMet = true;
                            array3[consequences++] = array2[i];
                        }
                    }
                }
            }

            Array.Resize(ref array3, consequences);
            length3 = array3.Length;
            Console.Write(Environment.NewLine + "{0} onsequences: ", consequences);
            for (int i = 0; i < length3; i++)
            {
                Console.Write(array3[i] + " ");
            }
            Console.WriteLine();
        }


    }
}

