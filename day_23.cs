using System;
using System.Collections.Generic;

class day_23
{
    public static void Main(string[] args)
    {
        Queue<string> customers = new Queue<string>();
        customers.Enqueue("Mia");
        customers.Enqueue("Leo");
        customers.Enqueue("Zoe");

        Console.WriteLine("Now serving: " + customers.Dequeue());
        Console.WriteLine("Customers waiting: " + customers.Count);
    }
}