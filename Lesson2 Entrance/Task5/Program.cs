using System;

/*Задание 5. Организовать ввод чисел(только чисел) с клавиатуры, пока пользователь не введёт 0.
После ввода нуля, показать на экран количество чисел, которые были введены, их общую сумму и среднее арифметическое.*/

namespace Task5
{
    class Program
    {
        static void Main(string[] args)
        {
            string answerStr;
            int sum = 0;
            int answerNum;
            int counter = 0;
            double mean;
            bool error;
            Console.WriteLine("Enter non-zero integer numbers and 0 to stop.");
            while (true)
            {
                error = false;
                answerStr = Console.ReadLine();
                int length = answerStr.Length;
                for (int i = 0; i < length; i++)
                {
                    if (char.IsNumber(answerStr[i]) == false && answerStr[i] != '-')
                    {
                        Console.WriteLine("Error!!! It isn't count.");
                        error = true;
                    }
                }
                if (error == false)
                {
                    answerNum = int.Parse(answerStr);
                    if (answerNum == 0)
                        break;
                    sum += answerNum;
                    counter++;
                }
            }
            mean = (double)sum / counter;
            Console.WriteLine("You entered {0} integer numbers. Their arithmetical mean is {1:N3}.", counter, mean);
        }
    }
}
