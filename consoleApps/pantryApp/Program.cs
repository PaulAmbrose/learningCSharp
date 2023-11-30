﻿using System;
using Food;

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
        Food.FoodItem pizza = new FoodItem("Pizza", 1, 10);

        kitchen.AddItem("spoon");
        kitchen.PrintItems();
        kitchen.RemoveItem("spoon");
        kitchen.PrintItems();
        Console.WriteLine(pizza);
    }
}
