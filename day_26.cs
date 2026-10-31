using System;

enum OrderStatus
{
    Pending,
    Shipped,
    Delivered
}

class day_26
{
    public static void Main(string[] args)
    {
        OrderStatus status = OrderStatus.Shipped;

        Console.WriteLine("Status: " + status);
        Console.WriteLine("Status code: " + (int)status);
    }
}