using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using reader;

namespace pantryAppCSharp
{
    class Kitchen
    {
        public string Name;
        public string shoppingListLocation = "C:/Users/PAmbrose/OneDrive - Clarion Housing Group Limited/Desktop/CSharpStaging/pantryAppCSharp/shoppingList/List1.txt";

        public List<string> fridge = new List<string>();
        public List<string> freezer = new List<string>();
        public List<string> storeCupboard = new List<string>();
        public List<string> fruitBowl = new List<string>();

        public int TransferFailure;
        public int TransferSuccess;

        public void AddItems()
        {
            TransferFailure = 0;
            TransferSuccess = 0;
            string fileContents = TextFileReader.ReadFile(shoppingListLocation);
            Console.WriteLine(fileContents);
        }
    }
}
