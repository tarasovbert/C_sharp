using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Files_Demo
{
    class Program
    {
        static void Main(string[] args)

        {
            string dirApp = Environment.CurrentDirectory;
            if (!Directory.Exists(Path.Combine(dirApp, "Text and binary files")))
                Directory.CreateDirectory(Path.Combine(dirApp, "Text and binary files"));
            string filesPath = Path.Combine(dirApp, "Text and binary files");
            DateTime now = DateTime.Now;
            string fileName = "TextFile.txt";
            File.AppendAllText(Path.Combine(dirApp, fileName), String.Format("{0}{1}", now.ToString("HH:mm:ss::ffff"), Environment.NewLine));
            fileName = "TextFile2.txt";
            StreamWriter sw = new StreamWriter("TextFile2.txt");
            sw.Write("Some more string.");
            sw.Close();
            StreamReader sr = new StreamReader("TextFile2.txt");
            Console.WriteLine(sr.ReadToEnd());
            sr.Close();
        }
    }
}
