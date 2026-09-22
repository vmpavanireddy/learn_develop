using System;

class day_4
{
    public static void Main(string[] args)
    {
        int score = 82;
        string grade;

        if (score >= 90)
        {
            grade = "A";
        }
        else if (score >= 80)
        {
            grade = "B";
        }
        else if (score >= 70)
        {
            grade = "C";
        }
        else if (score >= 60)
        {
            grade = "D";
        }
        else
        {
            grade = "F";
        }

        Console.WriteLine("Score: " + score);
        Console.WriteLine("Grade: " + grade);
    }
}