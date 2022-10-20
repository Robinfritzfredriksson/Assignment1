using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1.Services
{

    // Här är våran filhanterare, som sparar ner det till en fil. 
    internal static class FileManager
    {
        public static void Save(string filePath, string text)
        {
            try
            {
                using var sw = new StreamWriter(filePath);
                sw.WriteLine(text);
            }
            catch
            {
                Console.Clear();
                Console.WriteLine("Unable to save Contact");
                Console.ReadKey();
            }
        }

        public static string Read(string filePath)
        {
            try
            {
                using var sr = new StreamReader(filePath);
                return sr.ReadToEnd();
            }
            catch { }

            return "[]";
        }
    }
}
