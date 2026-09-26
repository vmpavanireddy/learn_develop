using System;

class day_5
{
    public static void Main(string[] args)
    {
        int number = 7;

        for (int multiplier = 1; multiplier <= 10; multiplier++)
        {
            int product = number * multiplier;
            Console.WriteLine(number + " x " + multiplier + " = " + product);
        }
    }
}