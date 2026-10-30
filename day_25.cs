using System;

class day_25
{
    public static void Main(string[] args)
    {
        DateTime startDate = new DateTime(2026, 10, 1);
        DateTime endDate = new DateTime(2026, 10, 10);
        TimeSpan difference = endDate - startDate;

        Console.WriteLine("Days between dates: " + difference.Days);
    }
}