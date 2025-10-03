namespace ADP_Lab02;
public class OrderService
{
    private void PrintOrder(string action, string productName, int quantity, double price)
    {
        double totalPrice = quantity * price;
        Console.WriteLine($"Order for {productName} {action}. Total: {totalPrice}");
    }

    public void CreateOrder(string productName, int quantity, double price)
    {
        PrintOrder("created", productName, quantity, price);
    }

    public void UpdateOrder(string productName, int quantity, double price)
    {
        PrintOrder("updated", productName, quantity, price);
    }
}
