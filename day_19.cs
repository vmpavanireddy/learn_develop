using System;

class day_19
{
    public static void Main(string[] args)
    {
        int[,] scores =
        {
            { 80, 90, 85 },
            { 75, 88, 92 }
        };
        int total = 0;

        for (int row = 0; row < scores.GetLength(0); row++)
        {
            for (int column = 0; column < scores.GetLength(1); column++)
            {
                total += scores[row, column];
            }
        }

        Console.WriteLine("Total score: " + total);
    }
}