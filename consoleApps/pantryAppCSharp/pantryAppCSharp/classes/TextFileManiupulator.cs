using System;
using System.IO;

namespace reader
{ 
    public class TextFileReader
    {
        public static string ReadFile(string filePath)
        {
            using (StreamReader reader = new StreamReader(filePath))
            {
                string contents = reader.ReadToEnd();
                return contents;
            }
        }
    }
}