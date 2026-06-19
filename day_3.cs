//operators
using System;   
class day_3
{
    public static void Main(string[] args)
    {
        int a = 10;
        int b = 20;
        //airthmetic operators
        //are used to perform mathematical operations on operands of numeric data types
        //they include addition (+), subtraction (-), multiplication (*), division (/), modulus (%)
        int c = a + b; // addition
        Console.WriteLine("Addition: " + c);
        
        int d = a - b; // subtraction
        Console.WriteLine("Subtraction: " + d);
        
        int e = a * b; // multiplication
        Console.WriteLine("Multiplication: " + e);
        
        int f = b / a; // division
        Console.WriteLine("Division: " + f);
        
        int g = b % a; // modulus
        Console.WriteLine("Modulus: " + g);

        //assignment operators
        //are used to assign values to variables
        //they include =, +=, -=, *=, /=, %=
        int h = 5; // assignment operator
        Console.WriteLine("Initial value of h: " + h);
        h += 10; // equivalent to h = h + 10
        Console.WriteLine("After += 10: " + h);
        h -= 3; // equivalent to h = h - 3
        Console.WriteLine("After -= 3: " + h);
        h *= 2; // equivalent to h = h * 2
        Console.WriteLine("After *= 2: " + h);
        h /= 4; // equivalent to h = h / 4
        Console.WriteLine("After /= 4: " + h);

        //increment and decrement operators
        //are used to increase or decrease the value of a variable by 1
        //they include ++ (increment) and -- (decrement)
        int i = 0;
        Console.WriteLine("Initial value of i: " + i);
        i++; // increment operator (post-increment)
        Console.WriteLine("After i++: " + i);
        ++i; // increment operator (pre-increment)
        Console.WriteLine("After ++i: " + i);
        i--; // decrement operator (post-decrement)
        Console.WriteLine("After i--: " + i);
        --i; // decrement operator (pre-decrement)
        Console.WriteLine("After --i: " + i);
        }
}