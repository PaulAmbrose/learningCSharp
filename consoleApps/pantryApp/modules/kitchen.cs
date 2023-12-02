namespace kitchenSpace
{
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

}