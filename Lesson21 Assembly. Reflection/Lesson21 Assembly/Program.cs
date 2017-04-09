using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using TestDll;

namespace Lesson21_Assembly
{
    class Program
    {
        static void Main(string[] args)
        {
            Car car = new Car() { Id = 1, Name = "BMW", Price = 50000 };
            Console.WriteLine(car);
            Console.Read();

            Assembly assembly = null;
            

            Type carType = typeof(Car);
            Console.WriteLine("typeof: {0}.", carType);
            Type type2 = Type.GetType("TestDll.Car");
            Console.WriteLine("Type.GetType: {0}.", type2);
            Type type3 = car.GetType();
            Console.WriteLine("car.GetType(): ", type3);
            Console.WriteLine("Name: {1}. {0}Base class: {2}. {0}Abstract: {3}. {0}Sealed: {4}. {0}Class: {5}. {0}" ,
                Environment.NewLine, carType.FullName, carType.BaseType, carType.IsAbstract, carType.IsSealed, carType.IsClass);

            foreach (MemberInfo mI in carType.GetMembers())
            {
                Console.WriteLine("CustomAttributes: {1}.{0} MemberType: {2}.{0} Name: {3}.{0}",
                    Environment.NewLine, mI.CustomAttributes, mI.MemberType, mI.Name);
            }

            

            try
            {
               assembly = Assembly.Load("ComplexLib");
               //assembly = Assembly.LoadFrom(@"D:\Tarasov\C#\Day21 Assembly\На выдачу_Рефлексия\ComplexLib.dll");

            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }            
            Console.WriteLine("dll {0} loaded sucsessfully!", assembly.FullName);
            Type[] types = assembly.GetTypes();
            foreach (MemberInfo mI in assembly.GetTypes())
            {
                Console.WriteLine("CustomAttributes: {1}.{0} MemberType: {2}.{0} Name: {3}.{0}",
                    Environment.NewLine, mI.CustomAttributes, mI.MemberType, mI.Name);
            }
            foreach (Type type in types) {
            MemberInfo[] members = type.GetMembers();
                foreach (MemberInfo element in members)
                    Console.WriteLine("{0, -15}: {1}", element.MemberType, element);


            }

        }
    }
}
