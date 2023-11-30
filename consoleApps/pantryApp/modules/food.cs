
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

    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    public double Amount
    {
        get { return amount; }
        set { amount = value; }
    }

    public double Cost
    {
        get { return cost; }
        set { cost = value; }
    }

    public override string ToString()
    {
        return Name + ": Amount: " + Amount + ", Cost: " + Cost;
    }
}

}