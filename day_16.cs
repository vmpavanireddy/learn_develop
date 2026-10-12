using System;

class day_16
{
    public static void Main(string[] args)
    {
        int length = 8;
        int width = 5;
        int area = CalculateArea(length, width);

        Console.WriteLine("Rectangle area: " + area);
    }

    static int CalculateArea(int length, int width)
    {
        return length * width;
    }
}