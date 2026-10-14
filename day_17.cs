using System;

class day_17
{
    public static void Main(string[] args)
    {
        int number = 5;
        Console.WriteLine(number + "! = " + Factorial(number));
    }

    static int Factorial(int number)
    {
        if (number <= 1)
        {
            return 1;
        }

        return number * Factorial(number - 1);
    }
}