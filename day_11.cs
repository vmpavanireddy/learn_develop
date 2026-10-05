using System;
using System.Collections.Generic;

class day_11
{
    public static void Main(string[] args)
    {
        List<string> tasks = new List<string> { "Read", "Practice", "Review" };

        tasks.Add("Rest");
        tasks.Remove("Review");

        Console.WriteLine("Tasks remaining: " + tasks.Count);
        foreach (string task in tasks)
        {
            Console.WriteLine(task);
        }
    }
}