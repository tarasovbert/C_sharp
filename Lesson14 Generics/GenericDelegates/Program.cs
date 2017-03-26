using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericDelegates
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int[] arr = { 1, 5, 8, 15 };
            Transformator.Transform(arr, b => b + 5);
            Console.WriteLine(String.Join(" ", arr));
            Console.Read();

            double[] arrD = { 1, 5, 8, 15 };
            Transformator.Transform(arrD, b => Math.Round(b*1.5));
            Console.WriteLine(String.Join(" ", arrD));
            Console.Read();
        }

      //  delegate T Transf<T>(T a); Func is instead of it

        class Transformator
        {
            public static void Transform<T>(T[] arr, Func<T,T> transf)//Func is instead of Transf
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    arr[i] = transf.Invoke(arr[i]);
                }
            }
        }
    }
}
