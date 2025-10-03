namespace AdpLab02;

public class Vehicle
{
    public Vehicle(string name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
    public void Start()
    {
        Console.WriteLine($"{Name} start");
    }

    public void Stop()
    {
        Console.WriteLine($"{Name} is stop");
    }
}

public class Car:Vehicle
{
    public Car(string name) : base(name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
}

public class Truck : Vehicle
{
    public Truck(string name) : base(name)
    {
        this.Name = name;
    }

    public string Name { get; set; }
}