using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

//http://www.regexr.com/

namespace RegularExpressions
{
    class Program
    {
        static void Main(string[] args)
        {
            //Task 1.
            Console.WriteLine("Task 1");
            string pattern = "abcdefghijklmnopqrstuv18340";
            string text1 = "wert42345 abcdefghijklmnopqrstuv18340.";
            string text2 = "wert2345 abcdefghirstuv18340.";
            Console.Write("{0}: {1}", nameof(text1), text1);
            if (Regex.IsMatch(text1, pattern))
                Console.WriteLine(" contains \"{0}\"", pattern);
            else
                Console.WriteLine(" DOES NOT!! contains \"{0}\"", pattern);

            Console.Write("{0}: {1}", nameof(text2), text2);
            if (Regex.IsMatch(text2, pattern))
                Console.WriteLine(" contains \"{0}\"", pattern);
            else
                Console.WriteLine(" DOES NOT!! contains \"{0}\"{1}", pattern, Environment.NewLine);

            //Task 2.
            Console.WriteLine("Task 2");
            pattern = @"(\d|[a-f]){8}(-(\d|[a-f]){4}){3}-(\d|[a-f]){12}";
            string mayBeGUID1 = "88888f88-4dd4-4ab4-4b44-1212cd121212";
            string mayBeGUID2 = "88888f884dd44ab44b441212cd121212";

            Console.Write("{0} {1}", nameof(mayBeGUID1), mayBeGUID1);
            if (Regex.IsMatch(mayBeGUID1, pattern))
                Console.WriteLine(" correspondents to GUID type.");
            else
                Console.WriteLine(" DOES NOT!! correspondents to GUID type.");

            Console.Write("{0} {1}", nameof(mayBeGUID2), mayBeGUID2);
            if (Regex.IsMatch(mayBeGUID2, pattern))
                Console.WriteLine(" correspondents to GUID type{0}", Environment.NewLine);
            else
                Console.WriteLine(" DOES NOT!! correspondents to GUID type.{0}", Environment.NewLine);





        }
    }
}
