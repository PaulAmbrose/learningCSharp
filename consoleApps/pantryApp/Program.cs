using System;
using Food;
using Shopping;

class Kitchen
{
    private List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
    }

    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
        }
        else
        {
            Console.WriteLine("Item not found");
        }
    }

    public void PrintItems()
    {
        Console.WriteLine("Items in kitchen:");
        foreach (string item in items)
        {
            Console.WriteLine(item);
        }
    }
}

class Program
{
    static void Main(string[] args)
    {
        Kitchen kitchen = new Kitchen();
        FoodItem pizza = new FoodItem("Pizza", 1, 10);
        Shopping newList = new List();


        //create a kitchen - add and remove items
        kitchen.AddItem("spoon");
        kitchen.PrintItems();
        kitchen.RemoveItem("spoon");
        kitchen.PrintItems();

        //craeate a food item.
        Console.WriteLine(pizza);

        //print the list
        //add pizza to the list
        //print the list
        //remove pizza from the list

    }
}
