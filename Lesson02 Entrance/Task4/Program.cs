using System;

/*Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы.
По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести найденное количество месяцев K 
и итоговый размер вклада S.*/

namespace Task4
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal deposit = 1000;
            decimal S = deposit;
            decimal upperBoarder = 1100;
            int counter = 0;
            Console.Write("The initial deposit is 1000 BYN. Enter the interest rank, percent: ");
            double P = double.Parse(Console.ReadLine())/100;
            while (S <= upperBoarder)
            {
                S += S*(decimal)P;
                counter++;
            }
            Console.WriteLine("The deposit will exceed 1100 BYN in {0} months and compose {1:c} BYN.", counter, S);
        }
    }
}
