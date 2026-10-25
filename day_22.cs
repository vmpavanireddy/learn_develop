using System;
using System.Collections.Generic;

class day_22
{
    public static void Main(string[] args)
    {
        HashSet<string> guests = new HashSet<string> { "Ava", "Noah", "Ava" };

        Console.WriteLine("Unique guests: " + guests.Count);
        Console.WriteLine("Is Noah invited? " + guests.Contains("Noah"));
    }
}