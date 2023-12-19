using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reader;
using System.IO;

namespace reader
{
    public static class FileHandler
    {
        public static void ReadLinesAndPrint(string filePath)
        {
            if (!File.Exists(filePath))
            {
                Console.WriteLine($"Error: File '{filePath}' doesn't exist.");
                return;
            }

            using (StreamReader reader = new StreamReader(filePath))
            {
                string line;
                while ((line = reader.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                    Console.WriteLine("***");
                }
            }

            Console.WriteLine("Finished reading file.");
        }
    }
}
