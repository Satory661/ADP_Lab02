namespace ADP_Lab02;

public class Singleton
{
    public void DoSomething()
    {
        Console.WriteLine("Doing something");
    }
}

public class Client
{
    public void Execute()
    {
        new Singleton().DoSomething();
    }
}
