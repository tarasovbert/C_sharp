using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Logger
{
    public class Logger
    {
        private static string pattern;
        static Logger()
        {
            pattern = "[UserName] [Data] [Message]";
            string fileIni = "logger.ini";
            if (File.Exists("logger.ini"))
            {
                var lines = File.ReadAllLines(fileIni);
                if (lines.Length != 0)
                    pattern = lines[0];
            }
        }

        public static void Write(string userName, TypeAction type, string message)
        {
            DateTime date = DateTime.Now;
            string info = String.Format("{0} {1} {2} {3} {4}",
                                        date.ToString("dd.MM.yyyy. HH:mm:ss."),
                                        userName,
                                        type,
                                        message, Environment.NewLine);

            StringBuilder strBuilder = new StringBuilder(pattern);
            strBuilder.Replace("[UserName]", userName);
            strBuilder.Replace("[Data]", date.ToString("dd.MM.yyyy. HH:mm:ss."));
            strBuilder.Replace("[Message]", message);
            strBuilder.Append(Environment.NewLine);

            //  string filePath = String.Empty;

            string dirApp = Environment.CurrentDirectory;

            if (!Directory.Exists(Path.Combine(dirApp, "Logs")))
                Directory.CreateDirectory(Path.Combine(dirApp, "Logs"));

            // string fileName = String.Format("{0}--{1}--{2}.txt", date.Year, date.Month.ToString().PadLeft(2, '0'), date.Day);
            string fileName = String.Format("{0}--{1:00}--{2:00}.txt", date.Year, date.Month, date.Day);
            string filePath = Path.Combine("Logs", fileName);

            File.AppendAllText(filePath, strBuilder.ToString());
        }
    }
}
