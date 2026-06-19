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
        //data type conversion
        //C# allows you to convert between different data types using casting or conversion methods.
        //casting is when you explicitly convert a value from one data type to another using parentheses.
        //conversion methods are built-in methods that allow you to convert a value from one data type to another, such as Convert.ToInt32(), Convert.ToString(), etc.
        //example of casting
        float score = 95.5f;
        int roundedScore = (int)score; //casting float to int
        Console.WriteLine("Rounded Score: " + roundedScore);
        //example of conversion method
        string scoreString = "95";
        int scoreInt = Convert.ToInt32(scoreString); //converting string to int
        Console.WriteLine("Score as Integer: " + scoreInt);
        //example of implicit conversion
        int smallNumber = 10;
        float largeNumber = smallNumber; //implicit conversion from int to float
        Console.WriteLine("Large Number: " + largeNumber);
        //example of explicit conversion
        float decimalNumber = 3.14f;
        int wholeNumber = (int)decimalNumber; //explicit conversion from float to int
        Console.WriteLine("Whole Number: " + wholeNumber);
        //example of using variables to store user input and converting it to the appropriate data type
        Console.WriteLine("Enter your rank no: ");
        string rankString = Console.ReadLine();
        int rank = Convert.ToInt32(rankString); //converting string input to int
        Console.WriteLine("Your rank is: " + rank);
        //data type conversion can lead to loss of data or precision if not done carefully, so it's important to understand the implications of converting between different data types.
        //example of potential data loss during conversion
        double largeDecimal = 123456789.987654321;
        float smallDecimal = (float)largeDecimal; //potential loss of precision when converting double to float
        Console.WriteLine("Large Decimal: " + largeDecimal);
        Console.WriteLine("Small Decimal: " + smallDecimal);
    }
}