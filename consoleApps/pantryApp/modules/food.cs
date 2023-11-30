
namespace Food
{

public class FoodItem
{
    private string name;
    private double amount;
    private double cost;

    public FoodItem(string name, double amount, double cost)
    {
        this.name = name;
        this.amount = amount;
        this.cost = cost;
    }
    public override string ToString()
    {
        return name + ": Amount: " + amount + ", Cost: " + cost;
    }
    }
}