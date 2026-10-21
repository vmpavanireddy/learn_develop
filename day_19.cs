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
        // Calculate the average score
        double average = total / (double)(scores.GetLength(0) * scores.GetLength(1));
        Console.WriteLine("Average score: " + average);
        // Determine pass or fail based on average score
        Console.WriteLine(average >= 50 ? "Result: Pass" : "Result: Fail");
        //example of jagged array
        int[][] jaggedScores = new int[2][];
        jaggedScores[0] = new int[] { 80, 90, 85 };
        jaggedScores[1] = new int[] { 75, 88, 92 };
        console.WriteLine("Jagged array scores:");
        for (int i = 0; i < jaggedScores.Length; i++)
        {
            for (int j = 0; j < jaggedScores[i].Length; j++)
            {
                Console.Write(jaggedScores[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}