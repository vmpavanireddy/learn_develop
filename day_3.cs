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

        //comparison operators
        //are used to compare two values and return a boolean result (true or false)
        //they include == (equal to), != (not equal to), > (greater than), < (less than), >= (greater than or equal to), <= (less than or equal to) 
        bool isEqual = a == b; // equal to operator
        Console.WriteLine("Is a equal to b? " + isEqual);
        bool isNotEqual = a != b; // not equal to operator
        Console.WriteLine("Is a not equal to b? " + isNotEqual);
        bool isLess = a < b; // less than operator
        Console.WriteLine("Is a less than b? " + isLess);
        bool isGreater = a > b; // greater than operator
        Console.WriteLine("Is a greater than b? " + isGreater);
        bool isGreaterOrEqual = a >= b; // greater than or equal to operator
        Console.WriteLine("Is a greater than or equal to b? " + isGreaterOrEqual);
        bool isLessOrEqual = a <= b; // less than or equal to operator
        Console.WriteLine("Is a less than or equal to b? " + isLessOrEqual);

        //relational operators
        //are used to compare two values and return a boolean result (true or false)
        //they include == (equal to), != (not equal to), > (greater than), < (less than), >= (greater than or equal to), <= (less than or equal to) 
        //in C#, comparison operators and relational operators are often used interchangeably, but they serve the same purpose of comparing values and returning boolean results.
        
        //logical operators
        //are used to combine multiple boolean expressions and return a boolean result (true or false)
        //they include && (logical AND), || (logical OR), ! (logical NOT)
        bool logicalAnd = (a < b) && (c > 0); // logical AND
        Console.WriteLine("Logical AND: " + logicalAnd);
        
        bool logicalOr = (a < b) || (c < 0); // logical OR
        Console.WriteLine("Logical OR: " + logicalOr);

        bool logicalNot = !(a < b); // logical NOT
        Console.WriteLine("Logical NOT: " + logicalNot);

        //bitwise operators
        //are used to perform bitwise operations on integer data types
        //they include & (bitwise AND), | (bitwise OR), ^ (bitwise XOR), ~ (bitwise NOT), << (left shift), >> (right shift)
        int bitwiseAnd = a & b; // bitwise AND
        Console.WriteLine("Bitwise AND: " + bitwiseAnd);
        int bitwiseOr = a | b; // bitwise OR
        Console.WriteLine("Bitwise OR: " + bitwiseOr);
        int bitwiseXor = a ^ b; // bitwise XOR
        Console.WriteLine("Bitwise XOR: " + bitwiseXor);
        int bitwiseNot = ~a; // bitwise NOT
        Console.WriteLine("Bitwise NOT: " + bitwiseNot);
        int leftShift = a << 2; // left shift
        Console.WriteLine("Left Shift: " + leftShift);
        int rightShift = a >> 2; // right shift
        Console.WriteLine("Right Shift: " + rightShift);

        //ternary operator
        //is a shorthand for an if-else statement that returns a value based on a condition
        //it has the syntax: condition ? value_if_true : value_if_false
        int ternaryResult = (a < b) ? a : b; // ternary operator
        Console.WriteLine("Ternary Operator Result: " + ternaryResult);
        //in this example, the condition (a < b) is true, so the value of a is returned and assigned to ternaryResult. If the condition were false, the value of b would be returned instead.
        //the ternary operator is a concise way to write simple conditional expressions and can help improve code readability when used appropriately.
        //it is important to use the ternary operator judiciously, as overusing it or using it in complex expressions can make code harder to read and understand.
        //in summary, operators are essential components of programming languages that allow us to perform various operations on data. Understanding the different types of operators and how to use them effectively is crucial for writing efficient and readable code in C#.
        //operators are fundamental to programming and are used in almost every aspect of coding, from simple calculations to complex logic. By mastering the use of operators, you can enhance your programming skills and create more powerful and efficient applications.
        }
}