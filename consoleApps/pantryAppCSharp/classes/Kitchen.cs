using System.Collections.Generic;


namespace pantryAppCSharp
{
    public class Kitchen
    {
        public string Name = "myKitchen";
        public string shoppingListLocation = "C:/Users/PAmbrose/OneDrive - Clarion Housing Group Limited/Desktop/CSharpStaging/pantryAppCSharp/shoppingList/List1.txt";
        public string[] locationsArrayForReference = new string[] { "fridge", "freezer", "storeCupboard", "fruitBowl" };

        public List<string> fridge = new List<string>();
        public List<string> freezer = new List<string>();
        public List<string> storeCupboard = new List<string>();
        public List<string> fruitBowl = new List<string>();

        public int TransferFailure;
        public int TransferSuccess;

        public void AddItems(Kitchen AKitchen)
        {
            TransferFailure = 0;
            TransferSuccess = 0;

            FileHandler.ReadLinesAndPrint(shoppingListLocation, AKitchen);
        }
    }
}
