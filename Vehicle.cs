public class Vehicle
{
    public string Name;
    // {
    //     get
    //     {
    //         return Name;
    //     }
    //     set
    //     {
    //         Name = value;
    //     }
    // }
    public int Passengers;
    public string Color;
    public bool Engine;
    public int MilesTraveled;

    public Vehicle(string name, int passengers, string color, bool engine)
    {
        Name = name;
        Passengers = passengers;
        Color = color;
        Engine = engine;
        
    }

    public virtual void ShowInfo()
    {
        System.Console.WriteLine($"Name: {Name}");
        System.Console.WriteLine($"# of Passengers: {Passengers}");
        System.Console.WriteLine($"Color: {Color}");
        System.Console.WriteLine($"Engine: {Engine}");
    }
}