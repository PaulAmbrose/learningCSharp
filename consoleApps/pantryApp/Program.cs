using foodSpace;
using shoppingSpace;
using kitchenSpace;

class Program
{
    static void Main(string[] args)
    {
        Kitchen houseKitchen = new Kitchen();
        FoodItem pizza = new FoodItem("Pizza", 1, 10);
        List newList = new List();

        //create a kitchen - add and remove items
        houseKitchen.AddItem("spoon");
        houseKitchen.PrintItems();
        houseKitchen.RemoveItem("spoon");
        houseKitchen.PrintItems();

        //create a food item.
        Console.WriteLine(pizza);

        //add pizza to the list

        //print the list

        //remove pizza from the list

    }   //print the list
}