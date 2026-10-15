using System;

class day_18
{
    public static void Main(string[] args)
    {
        int numerator = 10;
        int denominator = 0;

        try
        {
            int result = numerator / denominator;
            Console.WriteLine("Result: " + result);
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Cannot divide by zero.");
        }
        finally
        {
            Console.WriteLine("Calculation finished.");
        }
    }
}