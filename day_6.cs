using System;

class day_6
{
    public static void Main(string[] args)
    {
        int number = 1;
        int total = 0;

        while (number <= 5)
        {
            total += number;
            number++;
        }

        Console.WriteLine("Sum of numbers from 1 to 5: " + total);
    }
}