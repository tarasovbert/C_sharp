using System;

/*Задание 6. Ввести с клавиатуры номер трамвайного билета(6-значное число) и проверить является ли данный билет счастливым
(если на билете напечатано шестизначное число, и сумма первых трёх цифр равна сумме последних трёх, то этот билет считается счастливым).*/

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            string number;
            Console.Write("Enter the number of tram ticket " + Environment.NewLine + "to check if it's happy(natural integer, 6 digits): ");
            number = Console.ReadLine();
            if(char.GetNumericValue(number,0) + char.GetNumericValue(number, 1)  + char.GetNumericValue(number, 2) 
                == char.GetNumericValue(number, 3) + char.GetNumericValue(number, 4) + char.GetNumericValue(number, 5))               
                Console.WriteLine("It's a happy ticket! Eat it immediately to don't lost your happiness!");
            else
                Console.WriteLine("It's just an ordinary ticket. There's no sense to eat it. ");
           


        }
    }
}

