using System;
using System.IO;


namespace pantryAppCSharp
{
    public static class FileHandler
    {
        public static void ReadLinesAndPrint(string filePath, Kitchen AKitchen)
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
                    Console.Write("Please state location for this item:  ");
                    string UserLocation = Console.ReadLine();

                    if (Array.Exists(AKitchen.locationsArrayForReference, location => location.Equals(UserLocation, StringComparison.OrdinalIgnoreCase)))
                    {
                        Console.WriteLine($"The location '{UserLocation}' exists in the kitchen!");
                    }
                    else
                    {
                        Console.WriteLine($"The location '{UserLocation}' does not exist in the kitchen.");
                    }

                }
                Console.WriteLine("================");
                Console.WriteLine("Finished reading list");
            }
        }
    }
}
