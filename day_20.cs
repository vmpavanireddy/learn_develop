using System;
using System.Linq;

class day_20
{
    public static void Main(string[] args)
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
        int[] evenNumbers = numbers.Where(number => number % 2 == 0).ToArray();
        int total = evenNumbers.Sum();

        Console.WriteLine("Even numbers: " + string.Join(", ", evenNumbers));
        Console.WriteLine("Sum: " + total);
    }
}