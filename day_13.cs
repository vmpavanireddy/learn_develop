using System;

class day_13
{
    public static void Main(string[] args)
    {
        string input = "42";

        if (int.TryParse(input, out int number))
        {
            Console.WriteLine("Parsed number: " + number);
            Console.WriteLine("Double: " + (number * 2));
        }
        else
        {
            Console.WriteLine("Input is not a valid integer.");
        }
    }
}