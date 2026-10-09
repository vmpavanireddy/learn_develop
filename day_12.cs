using System;
using System.Collections.Generic;

class day_12
{
    public static void Main(string[] args)
    {
        Dictionary<string, decimal> prices = new Dictionary<string, decimal>
        {
            { "Notebook", 4.50m },
            { "Pen", 1.25m },
            { "Folder", 2.75m }
        };

        string item = "Pen";
        if (prices.TryGetValue(item, out decimal price))
        {
            Console.WriteLine(item + " costs $" + price);
        }
    }
}