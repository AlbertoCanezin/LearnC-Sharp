/*
using System;

public enum OrderStatus : int
{
    PendingPayment = 0,
    Processing = 1,
    Shipped = 2,
    Delivered = 3
}

public class Order
{
    public int Id { get; set; }
    public DateTime Moment { get; set; }
    public OrderStatus Status { get; set; }

    public override string ToString() {
        return Id
        + ", "
        + Moment
        + ", "
        + Status;
    }
}

public class Program
{
    public static void Main(string[] args)
    {
        Order order = new Order {
            Id = 1080,
            Moment = DateTime.Now,
            Status = OrderStatus.PendingPayment
        };
        Console.WriteLine(order);

        // Convertendo um enum para string
        string txt = OrderStatus.PendingPayment.ToString();
        Console.WriteLine(txt);

        // Convertendo uma string para enum
        OrderStatus os = Enum.Parse<OrderStatus>("Delivered");
        Console.WriteLine(os);
    }
}
*/