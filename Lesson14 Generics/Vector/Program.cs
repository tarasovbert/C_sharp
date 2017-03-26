using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicArray
{
    class Program
    {
        static void Main(string[] args)
        {
            #region STRING_VECTOR
            Vector<string> vec1 = new Vector<string>();
            vec1.Add("Tarasov Vova");
            Console.WriteLine(vec1.ToString());
            vec1.Add("Regino Artem");
            Console.WriteLine(vec1.ToString());
            vec1.Add("Ivanov Pavel", 1);
            Console.WriteLine(vec1.ToString());
            try
            {
                vec1.Add("A student", -1);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            try
            {
                vec1.Add("A student", 10);
            }
            catch (IndexOutOfRangeException ex)
            {
                Console.WriteLine(ex.Message);
            }
            vec1.Add("Tarasov Vova");
            Console.WriteLine(vec1.ToString());
            vec1.Add("Regino Artem");
            vec1.Add("Ivanov Pavel", 1);
            vec1.Add("Sermyajko Darja", 2);
            Console.WriteLine(vec1.ToString());
            vec1.DeleteElement(3);
            Console.WriteLine(vec1.ToString());
            Console.WriteLine(vec1.Search("Tarasov Vova"));
            Console.WriteLine(vec1.Search("Dokunov Vanya"));
            vec1.DeleteElement(3);
            vec1.Add("Dokunov Vanya", 2);

            Vector<string>.Sort(ref vec1);
            Console.WriteLine(vec1.ToString());
            Console.WriteLine("Length of vec1 is: {0}", vec1.Lenght);
            Console.WriteLine("Type of vec1 is {0}", typeof(Vector<string>));

            vec1.ClearAll();
            Console.WriteLine(vec1.ToString());
            #endregion

            #region CHAR_VECTOR
            Vector<char> vec2 = new Vector<char>('B');
            vec2.Add('z');
            char result;
            while (!char.TryParse("s", out result)) { }
            vec2.Add(result);
            Console.WriteLine(vec2.ToString());
            vec2.Add('f');
            vec2.Add('2');
            vec2.Add('$');
            vec2.Add('&');
            vec2.Add('6', 0);
            vec2.Add('r', 2);
            vec2.Add('e');
            vec2.Add('a');
            vec2.Add('0');
            vec2.Add('№');
            Console.WriteLine(vec2.ToString());
            Console.WriteLine("Length of vec2 is: {0}", vec2.Lenght);
            vec2.DeleteElement(8);
            Vector<char>.Sort(ref vec2);
            Console.WriteLine(vec2.ToString());
            Console.WriteLine("Length of vec2 is: {0}", vec2.Lenght);
            Console.WriteLine("Type of vec2 is {0}", typeof(Vector<string>));
            vec2.ClearAll();
            Console.WriteLine(vec2.ToString());
            #endregion

            #region CLASS_WORKER_VECTOR
            Worker worker1 = new Worker("Tarasov Vova", 300);
            Vector<Worker> workers = new Vector<Worker>(worker1);
            Worker worker2 = new Worker("Ryabtseva Anna", 320);
            workers.Add(worker2);
            Worker worker3 = new Worker("Mantcevich Alexey", 280);
            workers.Add(worker3);
            Worker worker4 =  new Worker("Vasil'ev Egor", 330);
            workers.Add(worker4, 1);
            Console.WriteLine(workers.ToString());
            workers.Add(worker4, 1);            
            Console.WriteLine(workers.ToString());
            workers.DeleteElement(1);
            Vector<Worker>.Sort(ref workers);
            Console.WriteLine(workers.ToString());
            Console.WriteLine(workers.Search(worker1));
            Worker worker5 = new Worker("Vasyukevich Alexander", 333);
            Console.WriteLine(workers.Search(worker5));
            workers.ClearAll();
            Console.WriteLine(workers.ToString());
            #endregion

            #region INT_VECTOR
            Vector<int> vec3 = new Vector<int>(100);
            vec3.Add(0);
            vec3.Add(-52);
            vec3.Add(12, 1);
            Console.WriteLine(vec3.ToString());
            Vector<int>.Sort(ref vec3);
            Console.WriteLine(vec3.ToString());
            Console.WriteLine(vec3.Search(12));
            Console.WriteLine(vec3.Search(13));
            vec3.DeleteElement(1);
            Console.WriteLine(vec3.ToString());
            vec3.ClearAll();
            Console.WriteLine(vec3.ToString());
            #endregion

            #region DOUBLE_VECTOR
            Vector<double> vec4 = new Vector<double>(100.4);
            vec4.Add(0.3);
            vec4.Add(-52.4);
            vec4.Add(12.7, 1);
            Console.WriteLine(vec4.ToString());
            Vector<double>.Sort(ref vec4);
            Console.WriteLine(vec4.ToString());
            Console.WriteLine(vec4.Search(12.7));
            Console.WriteLine(vec4.Search(13.9));
            vec4.DeleteElement(1);
            Console.WriteLine(vec4.ToString());
            vec4.ClearAll();
            Console.WriteLine(vec4.ToString());
            #endregion

        }
    }
}
