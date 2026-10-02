using System;

class day_9
{
    public static void Main(string[] args)
    {
        int dayNumber = 3;
        string dayName;

        switch (dayNumber)
        {
            case 1:
                dayName = "Monday";
                break;
            case 2:
                dayName = "Tuesday";
                break;
            case 3:
                dayName = "Wednesday";
                break;
            case 4:
                dayName = "Thursday";
                break;
            case 5:
                dayName = "Friday";
                break;
            default:
                dayName = "Weekend or invalid day";
                break;
        }

        Console.WriteLine(dayName);
    }
}