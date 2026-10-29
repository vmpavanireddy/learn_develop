using System;
using System.Collections.Generic;

class day_24
{
    public static void Main(string[] args)
    {
        Stack<string> books = new Stack<string>();
        books.Push("Math");
        books.Push("Science");
        books.Push("History");

        Console.WriteLine("Take from the top: " + books.Pop());
        Console.WriteLine("Books remaining: " + books.Count);
    }
}