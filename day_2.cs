//data type
using System;
class Program
{
    static void Main(String[] args)
    {
        //A data type tells C# what kind of data it can store.
        //C# has several built-in data types, such as int, float, double, char, string, bool, etc.
        //int is used to store whole numbers, such as 1, 2, 3, etc.
        //float is used to store decimal numbers, such as 1.5, 2.5, etc.
        //double is used to store larger decimal numbers, such as 1.5, 2.5, etc.
        //char is used to store a single character, such as 'a', 'b', 'c', etc.
        //string is used to store a sequence of characters, such as "Hello", "World", etc.
        //bool is used to store a value of true or false.
        //example of declaring and initializing variables with different data types
        int health = 100;
        float speed = 5.5f;
        string playerName = "pavani";
        bool isAlive = true;
        int coins = 0;
        //example of using variables in an expression
        int damage = 10;
        health = health - damage;
        Console.WriteLine("Player Name: " + playerName);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Speed: " + speed);
        Console.WriteLine("Is Alive: " + isAlive);
        Console.WriteLine("Coins: " + coins);
    }
}