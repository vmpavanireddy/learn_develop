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
int[] num_2 = { 10, 20, 30, 40, 50 };

for (int i = num_2.Length - 1; i >= 0; i--)
{
    Console.WriteLine(num_2[i]);
}
//Searching

int[] numbers_3 = { 10, 20, 30, 40, 50 };

int target = 30;
bool found = false;

for (int i = 0; i < numbers_3.Length; i++)
{
    if (numbers_3[i] == target)
    {
        Console.WriteLine("Found at index: " + i);
        found = true;
        break;
    }
}

if (!found)
{
    Console.WriteLine("Not found");
}
int[] numbers_4 = { 10, 20, 30, 40, 50 };

int target_1 = 40;

int left = 0;
int right = numbers_4.Length - 1;

while (left <= right)
{
    int middle = (left + right) / 2;

    if (numbers_4[middle] == target_1)
    {
        Console.WriteLine("Found at index: " + middle);
        break;
    }
    else if (numbers_4[middle] < target_1)
    {
        left = middle + 1;
    }
    else
    {
        right = middle - 1;
    }
}