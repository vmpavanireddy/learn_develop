# Day 2 – Data Types in C#

## Learning Goal

Understand what Data Types are, why they are important, and how they are used in real-world game development.

---

# What is a Data Type?

A Data Type tells C# what kind of data a variable can store.

Every variable must have a data type.

Example:

```csharp
int health = 100;
```

Here:

* `int` = Data Type
* `health` = Variable Name
* `100` = Value

The computer now knows that health can store whole numbers.

---

# Why Are Data Types Important?

Games constantly store information such as:

| Game Data   | Example |
| ----------- | ------- |
| Health      | 100     |
| Coins       | 50      |
| Speed       | 5.5     |
| Player Name | Murali  |
| Is Alive    | True    |

Without data types, the computer would not know how to store or process these values.

---

# Common Data Types in C#

## 1. int

### Definition

Stores whole numbers.

### Syntax

```csharp
int health = 100;
```

### Examples

```csharp
int health = 100;
int score = 500;
int coins = 25;
int level = 1;
```

### Game Development Usage

* Health
* Score
* Coins
* Levels
* Ammo

### Why Use int?

Because these values do not require decimal points.

---

# 2. float

## Definition

Stores decimal numbers.

## Syntax

```csharp
float speed = 5.5f;
```

### Examples

```csharp
float speed = 5.5f;
float jumpForce = 10.2f;
float gravity = 9.8f;
```

### Game Development Usage

* Player Speed
* Jump Force
* Gravity
* Movement Values

### Why Use float?

Because movement and physics often require decimal precision.

---

# 3. double

## Definition

Stores large decimal values with higher precision than float.

### Syntax

```csharp
double accuracy = 99.9999;
```

### Examples

```csharp
double accuracy = 99.9999;
double distance = 12345.6789;
```

### Why Use double?

When more precision is required.

### Difference Between float and double

| float          | double          |
| -------------- | --------------- |
| 32-bit         | 64-bit          |
| Less precision | More precision  |
| Faster         | Slightly slower |

---

# 4. string

## Definition

Stores text.

### Syntax

```csharp
string playerName = "Murali";
```

### Examples

```csharp
string playerName = "Murali";
string weaponName = "Sword";
string gameName = "Space Adventure";
```

### Game Development Usage

* Player Name
* Weapon Name
* Dialogue
* Messages

---

# 5. char

## Definition

Stores a single character.

### Syntax

```csharp
char grade = 'A';
```

### Examples

```csharp
char rank = 'S';
char grade = 'A';
```

### Difference

```csharp
char letter = 'A';
string word = "A";
```

char stores one character.

string stores multiple characters.

---

# 6. bool

## Definition

Stores only:

```text
true
false
```

### Syntax

```csharp
bool isAlive = true;
```

### Examples

```csharp
bool isAlive = true;
bool hasKey = false;
bool gameCompleted = false;
```

### Game Development Usage

* Is Player Alive?
* Has Key?
* Door Open?
* Game Finished?

---

# Program Practiced Today

```csharp
int health = 100;
float speed = 5.5f;
string playerName = "Pavani";
bool isAlive = true;
int coins = 0;
```

---

# Damage Calculation Example

```csharp
int health = 100;
int damage = 10;

health = health - damage;
```

### Output

```text
Health = 90
```

### Real Game Usage

Player takes damage.

---

# Type Conversion

## What is Type Conversion?

Converting one data type into another.

# Explicit Casting

## Definition

Manually converting one data type to another.

### Example

```csharp
float score = 95.5f;
int roundedScore = (int)score;
```

### Output

```text
95
```

### Observation

Decimal part is removed.

---

# Convert Method

## Definition

Uses built-in methods to convert data types.

### Example

```csharp
string scoreString = "95";
int scoreInt = Convert.ToInt32(scoreString);
```

### Output

```text
95
```

---

# Implicit Conversion

## Definition

Automatic conversion by C#.

### Example

```csharp
int smallNumber = 10;
float largeNumber = smallNumber;
```

### Output

```text
10
```

### Why It Works?

No data loss occurs.

---

# Explicit Conversion Example

```csharp
float decimalNumber = 3.14f;
int wholeNumber = (int)decimalNumber;
```

### Output

```text
3
```

### Observation

Decimal value is lost.

---

# User Input

## Example

```csharp
Console.WriteLine("Enter your rank:");

string rankString = Console.ReadLine();

int rank = Convert.ToInt32(rankString);

Console.WriteLine(rank);
```

### Important Note

Console.ReadLine() always returns a string.

Therefore conversion may be required.

---

# Precision Loss

## Example

```csharp
double largeDecimal = 123456789.987654321;

float smallDecimal = (float)largeDecimal;
```

### Observation

Some precision is lost.

### Why?

float has less memory than double.

---

# Real Game Development Examples

| Variable         | Data Type |
| ---------------- | --------- |
| Health           | int       |
| Coins            | int       |
| Ammo             | int       |
| Score            | int       |
| Speed            | float     |
| Jump Force       | float     |
| Gravity          | float     |
| Accuracy         | double    |
| Player Name      | string    |
| Weapon Name      | string    |
| Rank             | char      |
| Is Alive         | bool      |
| Has Key          | bool      |
| Mission Complete | bool      |

---

# Key Takeaways

1. Every variable needs a data type.
2. int stores whole numbers.
3. float stores decimal numbers.
4. double stores larger decimal values with higher precision.
5. string stores text.
6. char stores one character.
7. bool stores true/false values.
8. Data types help the computer store and process data correctly.
9. Type conversion may cause data loss.
10. User input often requires conversion.

---


### Q1. What is a Data Type?

A Data Type defines what kind of value a variable can store.

---

### Q2. Difference between int and float?

int stores whole numbers.

float stores decimal numbers.

---

### Q3. Difference between float and double?

double has more precision and larger storage than float.

---

### Q4. Why is speed usually stored as float?

Because movement often requires decimal values.

---

### Q5. Why is health usually stored as int?

Health is generally represented using whole numbers.

