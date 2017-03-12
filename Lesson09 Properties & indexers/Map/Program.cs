using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Map
{
    class Program
    {
        static void Main(string[] args)
        {
            Map map = new Map();
            Console.WriteLine("New empty map created.{0}Map's quantity of writings: {1}{0}",
                Environment.NewLine, map.Count);

            map.Add("Writing #1", 0.1);
            map.Add("Writing #2", 0.22);
            map.Add("Writing #3", 0.333);
            map.Add("Writing #4", 0.4444);
            Console.WriteLine("Map's quantity of writings: {0}{1}", map.Count, Environment.NewLine);

            string[] keys = map.GetKeys;
            Console.WriteLine("Map's keys are: ");
            for (int i = 0; i < keys.Length; i++)
                Console.WriteLine(keys[i]);
            Console.WriteLine();

            double[] values = map.GetValues;
            Console.WriteLine("Map's values are: ");
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine(values[i]);
            Console.WriteLine();

            string key1 = "Ritting #1";
            string key2 = "Writing #2";
            Console.WriteLine("The key \"{0}\" contains in the dictionary: {1}",
                key1, map.ContainsKey(key1));
            Console.WriteLine("The key \"{0}\" contains in the dictionary: {1}{2}",
                key2, map.ContainsKey(key2), Environment.NewLine);

            double value1 = 0.2;
            double value2 = 0.333;
            Console.WriteLine("The value \"{0}\" contains in the dictionary: {1}",
              value1, map.ContainsValue(value1));
            Console.WriteLine("The key \"{0}\" contains in the dictionary: {1}{2}",
                value2, map.ContainsValue(value2), Environment.NewLine);

            Console.WriteLine("Remove the entry with key \"{0}\": {1}", key1, map.Remove(key1));
            Console.WriteLine("Remove the entry with key \"{0}\": {1}{2}", key2, map.Remove(key2), Environment.NewLine);

            keys = map.GetKeys;
            Console.WriteLine("Map's keys are: ");
            for (int i = 0; i < keys.Length; i++)
                Console.WriteLine(keys[i]);
            Console.WriteLine();

            values = map.GetValues;
            Console.WriteLine("Map's values are: ");
            for (int i = 0; i < values.Length; i++)
                Console.WriteLine(values[i]);
            Console.WriteLine();
            Console.WriteLine("Map's quantity of writings: {0}{1}", map.Count, Environment.NewLine);

            double value3;
            map.TryGetValue(key1, out value3);
            Console.WriteLine("The value of key \"{0}\" is {1}", key1, value3);
            key2 = "Writing #3";
            map.TryGetValue(key2, out value3);
            Console.WriteLine("The value of key \"{0}\" is {1}", key2, value3);

            map.Clear();
            Console.WriteLine("{0}Now the map is clear.{0}Quantity of writings is {1}{0}", Environment.NewLine, map.Count);




        }
    }
}
