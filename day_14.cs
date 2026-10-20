using System;

class day_14
{
    public static void Main(string[] args)
    {
        double sideA = 3;
        double sideB = 4;
        double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) + Math.Pow(sideB, 2));

        Console.WriteLine("Hypotenuse: " + hypotenuse);
    }
}