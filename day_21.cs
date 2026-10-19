using System;

class day_21
{
    public static void Main(string[] args)
    {
        Student student = new Student("Ava", 92);
        student.DisplayInfo();
    }
}

class Student
{
    public string Name { get; }
    public int Score { get; }

    public Student(string name, int score)
    {
        Name = name;
        Score = score;
    }

    public void DisplayInfo()
    {
        Console.WriteLine("Student: " + Name);
        Console.WriteLine("Score: " + Score);
    }
}