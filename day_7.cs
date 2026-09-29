using System;

class day_7
{
    public static void Main(string[] args)
    {
        int countdown = 5;

        do
        {
            Console.WriteLine(countdown);
            countdown--;
        }
        while (countdown > 0);

        Console.WriteLine("Go!");
    }
}