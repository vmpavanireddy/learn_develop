using System;

class Program
{
	public static void Main(string[] args)
	{
		int firstScore = 78;
		int secondScore = 85;
		int thirdScore = 92;

		int total = firstScore + secondScore + thirdScore;
		double average = total / 3.0;

		Console.WriteLine("Total score: " + total);
		Console.WriteLine("Average score: " + average);
		Console.WriteLine(average >= 50 ? "Result: Pass" : "Result: Fail");
	}
}
