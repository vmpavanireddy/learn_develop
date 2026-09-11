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

int[] numb = { 25, 10, 45, 30, 15 };

int smallest = numb[0];

for (int i = 1; i < numb.Length; i++)
{
    if (numb[i] < smallest)
    {
        smallest = numb[i];
    }
}

Console.WriteLine("Smallest: " + smallest);
int[] numb_1 = { 10, 20, 30, 40, 50 };

int sum = 0;

for (int i = 0; i < numb_1.Length; i++)
{
    sum += numb_1[i];
}

Console.WriteLine("Sum: " + sum);