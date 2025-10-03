namespace ADP_Lab02;
public class MathOperations
{
    public int Add(int a, int b, bool shouldLog = false)
    {
        int result = a + b;
        if (shouldLog)
        {
            Console.WriteLine($"Result: {result}");
        }
        return result;
    }
}
