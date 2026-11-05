using System;

class day_29
{
    public static void Main(string[] args)
    {
        int? score = null;
        Console.WriteLine("Score with default: " + (score ?? 0));

        score = 95;
        Console.WriteLine("Score: " + score.Value);
    }
}