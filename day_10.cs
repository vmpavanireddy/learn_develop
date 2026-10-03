using System;

class day_10
{
    public static void Main(string[] args)
    {
        for (int number = 1; number <= 10; number++)
        {
            if (number == 3)
            {
                continue;
            }

            if (number == 8)
            {
                break;
            }

            Console.WriteLine(number);
        }
    }
}