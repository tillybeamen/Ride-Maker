Vehicle Honda = new Vehicle("Honda", 4, "Black", false);
Vehicle Bentley = new Vehicle("Bentley", 2, "White", true);
Vehicle Jaguar = new Vehicle("Jaguar", 2, "Red", true);
Vehicle Buick = new Vehicle("Buick", 5, "Green", true);

List<Vehicle> AllVehicles = new List<Vehicle>();
AllVehicles.Add(Honda);
AllVehicles.Add(Bentley);
AllVehicles.Add(Jaguar);
AllVehicles.Add(Buick);

foreach(Vehicle v in AllVehicles)
{
    v.ShowInfo();
}

System.Console.WriteLine(Honda.Name);
System.Console.WriteLine(Bentley.Passengers);
System.Console.WriteLine(Jaguar.Color);
System.Console.WriteLine(Buick.Engine);