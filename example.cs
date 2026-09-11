//Array — Traversing
int[] numbers = { 10, 20, 30, 40, 50 };

for (int i = 0; i < numbers.Length; i++)
{
    Console.WriteLine(numbers[i]);
}
int[] num = { 25, 10, 45, 30, 15 };

int largest = num[0];

for (int i = 1; i < num.Length; i++)
{
    if (num[i] > largest)
    {
        largest = num[i];
    }
}

Console.WriteLine("Largest: " + largest);

