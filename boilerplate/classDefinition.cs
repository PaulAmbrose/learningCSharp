/// This class represents a person with a name and an age.
class Person
{
    /// The name of the person.
    private string name;

    /// The age of the person.
    private int age;

    /// Creates a new person with the specified name and age.
    /// Constructor
    public Person(string name, int age)
    {
        this.name = name;
        this.age = age;
    }

    /// Gets the name of the person.
    public string Name
    {
        get { return name; }
        set { name = value; }
    }

    /// Gets the age of the person.
    public int Age
    {
        get { return age; }
        set { age = value; }
    }

    /// Prints the name and age of the person to the console.
    public void PrintInfo()
    {
        Console.WriteLine("Name: " + name);
        Console.WriteLine("Age: " + age);
    }
}
