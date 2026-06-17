//Learn Variables
using System;
//variable is a container for storing data
//variable has a name and a value
//variable can be of different types: int, string, bool, etc.
//variable can be declared and initialized
//variable can be used to store and manipulate data
//variable can be used in expressions and statements
//variable can be used in loops and functions
//variable can be used to store user input
//variable can be used to store the result of a calculation
//example of declaring and initializing a variable
class Program
{
    static void Main(string[] args)
    {
        int age = 21;
        string playername = "pavani";
        bool isAlive = true;
        int health = 100;
        int coins = 0;
        float speed = 5.5f;
//example of using variables in an expression
        int damage = 10;
        health = health - damage;
        Console.WriteLine("Player Name: " + playername);
        Console.WriteLine("Age: " + age);
        Console.WriteLine("Health: " + health);
        Console.WriteLine("Coins: " + coins);
        Console.WriteLine("Speed: " + speed);
        //example of using variables-modification
        coins = coins + 10;
        Console.WriteLine("Coins after collecting: " + coins);
        Console.WriteLine("Is Alive: " + isAlive);
        Console.WriteLine("Damage Taken: " + damage);
        //example of using variables in a loop
        for (int i = 0; i < 5; i++)
        {
            health = health - damage;
            Console.WriteLine("Health after taking damage: " + health);
        }
        //example of using variables in a function
        int totalScore = CalculateScore(coins, health);
        Console.WriteLine("Total Score: " + totalScore);
        //example of using variables to store user input
        Console.WriteLine("Enter your name: ");
        string userName = Console.ReadLine();
        Console.WriteLine("Hello, " + userName + "!");
    }
    static int CalculateScore(int coins, int health)
    {
        return coins * 10 + health;
    }
}
