# Day 3 – Operators in C#

# Learning Goal

Understand Operators in C# and how they are used in real-world Game Development.

Operators allow us to:

* Perform calculations
* Compare values
* Update game state
* Control game logic
* Make decisions

Without operators, games cannot:

* Increase score
* Reduce health
* Check win conditions
* Unlock achievements
* Move between levels

---

# What is an Operator?

An Operator is a symbol that performs an operation on variables or values.

---

# Types of Operators

1. Arithmetic Operators
2. Assignment Operators
3. Increment & Decrement Operators
4. Comparison Operators
5. Logical Operators
6. Bitwise Operators
7. Ternary Operator

---

# 1. Arithmetic Operators

Used to perform mathematical calculations.

| Operator | Meaning             |
| -------- | ------------------- |
| +        | Addition            |
| -        | Subtraction         |
| *        | Multiplication      |
| /        | Division            |
| %        | Modulus (Remainder) |

---

## Addition Operator (+)

```csharp
int coins = 10;
coins = coins + 5;
```

Output:

```text
15
```

Game Example:

Player collects 5 coins.

---

## Subtraction Operator (-)

```csharp
int health = 100;
int damage = 20;

health = health - damage;
```

Output:

```text
80
```

Game Example:

Player takes damage.

---

## Multiplication Operator (*)

```csharp
int damage = 10;
damage = damage * 2;
```

Output:

```text
20
```

Game Example:

Critical Hit.

---

## Division Operator (/)

```csharp
int health = 100;
health = health / 2;
```

Output:

```text
50
```

Game Example:

Poison Effect.

---

## Modulus Operator (%)

Returns remainder.

```csharp
int result = 10 % 3;
```

Output:

```text
1
```

Game Example:

Reward every 5 levels.

```csharp
if(level % 5 == 0)
{
    Console.WriteLine("Bonus Reward");
}
```

---

# Integer Division

Important Interview Topic

```csharp
int result = 5 / 2;
```

Output:

```text
2
```

Why?

Because both values are integers.

Correct:

```csharp
float result = 5f / 2f;
```

Output:

```text
2.5
```

---

# 2. Assignment Operators

Used to assign or update values.

---

## =

```csharp
int health = 100;
```

Assigns value.

---

## +=

```csharp
coins += 10;
```

Equivalent to:

```csharp
coins = coins + 10;
```

---

## -=

```csharp
health -= 20;
```

Equivalent to:

```csharp
health = health - 20;
```

---

## *=

```csharp
damage *= 2;
```

Equivalent to:

```csharp
damage = damage * 2;
```

---

## /=

```csharp
health /= 2;
```

Equivalent to:

```csharp
health = health / 2;
```

---

## %=

```csharp
score %= 10;
```

Stores remainder.

---

# 3. Increment and Decrement Operators

Used to increase or decrease values by 1.

---

## Increment (++)

```csharp
level++;
```

Equivalent to:

```csharp
level = level + 1;
```

Game Example:

Level Up.

---

## Decrement (--)

```csharp
lives--;
```

Equivalent to:

```csharp
lives = lives - 1;
```

Game Example:

Lose Life.

---

# Pre Increment vs Post Increment

Very Important Interview Topic

---

## Post Increment

```csharp
int x = 5;

Console.WriteLine(x++);
```

Output:

```text
5
```

After execution:

```text
x = 6
```

---

## Pre Increment

```csharp
int x = 5;

Console.WriteLine(++x);
```

Output:

```text
6
```

---

# 4. Comparison Operators

Used to compare values.

Return:

```text
true
false
```

---

## Equal To (==)

```csharp
a == b
```

---

## Not Equal To (!=)

```csharp
a != b
```

---

## Greater Than (>)

```csharp
a > b
```

---

## Less Than (<)

```csharp
a < b
```

---

## Greater Than Or Equal To (>=)

```csharp
a >= b
```

---

## Less Than Or Equal To (<=)

```csharp
a <= b
```

---

# Game Development Examples

## Game Over

```csharp
health <= 0
```

---

## Boss Unlock

```csharp
level >= 10
```

---

## Mission Complete

```csharp
score >= 1000
```

---

# Difference Between = and ==

Assignment:

```csharp
health = 100;
```

Comparison:

```csharp
health == 100
```

Interviewers ask this frequently.

---

# 5. Logical Operators

Used to combine conditions.

---

## Logical AND (&&)

Both conditions must be true.

```csharp
hasKey && nearDoor
```

---

## Logical OR (||)

At least one condition must be true.

```csharp
hasVIPPass || hasPremiumPass
```

---

## Logical NOT (!)

Reverses condition.

```csharp
!isAlive
```

Meaning:

Player is not alive.

---

# Real Game Examples

## Open Door

```csharp
hasKey && nearDoor
```

---

## Unlock Reward

```csharp
score >= 100 || hasSpecialPass
```

---

## Respawn

```csharp
!isAlive
```

---

# 6. Bitwise Operators

Operate on binary values.

Advanced topic.

---

## Bitwise AND (&)

```csharp
a & b
```

---

## Bitwise OR (|)

```csharp
a | b
```

---

## Bitwise XOR (^)

```csharp
a ^ b
```

---

## Bitwise NOT (~)

```csharp
~a
```

---

## Left Shift (<<)

```csharp
a << 2
```

---

## Right Shift (>>)

```csharp
a >> 2
```

---

# Where Bitwise Operators Are Used

* Networking
* Multiplayer Games
* Performance Optimization
* Flag Systems

Not commonly used in beginner Unity projects.

---

# 7. Ternary Operator

Short version of if-else.

Syntax:

```csharp
condition ? valueIfTrue : valueIfFalse;
```

Example:

```csharp
int result = (a < b) ? a : b;
```

Meaning:

If a < b

Return a

Else

Return b

---

# Operator Precedence

Important Interview Topic

Example:

```csharp
int result = 10 + 5 * 2;
```

Output:

```text
20
```

Why?

Multiplication executes first.

Equivalent:

```csharp
10 + (5 * 2)
```

---

# Real Game Development Usage

| Scenario             | Operator |   |   |
| -------------------- | -------- | - | - |
| Gain Coins           | +        |   |   |
| Lose Health          | -        |   |   |
| Critical Hit         | *        |   |   |
| Split Damage         | /        |   |   |
| Bonus Every 5 Levels | %        |   |   |
| Level Up             | ++       |   |   |
| Lose Life            | --       |   |   |
| Check Health         | <=       |   |   |
| Open Door            | &&       |   |   |
| VIP Access           |          |   |   |
| Respawn              | !        |   |   |
| Quick Decision       | ?:       |   |   |

---

# What I Learned Today

* Operators manipulate data.
* Arithmetic operators perform calculations.
* Assignment operators update values.
* Comparison operators return boolean results.
* Logical operators combine conditions.
* Ternary operator simplifies decisions.
* Bitwise operators work on binary data.
* Operator precedence affects execution order.

# Common Interview Questions

### What is an Operator?

A symbol that performs an operation on values or variables.

---

### Difference Between = and == ?

= Assigns value.

== Compares values.

---

### Difference Between ++i and i++ ?

++i increments first.

i++ uses value first, then increments.

---

### Output?

```csharp
int x = 5;

Console.WriteLine(x++);
Console.WriteLine(x);
```

Answer:

```text
5
6
```

---

### Output?

```csharp
Console.WriteLine(10 % 3);
```

Answer:

```text
1
```

---

### Output?

```csharp
int result = 10 + 5 * 2;
```

Answer:

```text
20
```

---