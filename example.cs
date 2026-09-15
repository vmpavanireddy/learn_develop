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

//Sorting
int[] numbers_5 = { 5, 2, 8, 1, 3 };

for (int i = 0; i < numbers_5.Length - 1; i++)
{
    for (int j = 0; j < numbers_5.Length - 1 - i; j++)
    {
        if (numbers_5[j] > numbers_5[j + 1])
        {
            int temp = numbers_5[j];
            numbers_5[j] = numbers_5[j + 1];
            numbers_5[j + 1] = temp;
        }
    }
}

for (int i = 0; i < numbers_5.Length; i++)
{
    Console.Write(numbers_5[i] + " ");
}

int[] numbers_6 = { 5, 2, 8, 1, 3 };

for (int i = 0; i < numbers_6.Length - 1; i++)
{
    int smallestIndex = i;

    for (int j = i + 1; j < numbers_6.Length; j++)
    {
        if (numbers_6[j] < numbers_6[smallestIndex])
        {
            smallestIndex = j;
        }
    }

    int temp = numbers_6[i];
    numbers_6[i] = numbers_6[smallestIndex];
    numbers_6[smallestIndex] = temp;
}

for (int i = 0; i < numbers_6.Length; i++)
{
    Console.Write(numbers_6[i] + " ");
}

int[] numbers_7 = { 5, 2, 8, 1, 3 };

for (int i = 1; i < numbers_7.Length; i++)
{
    int current = numbers_7[i];
    int j = i - 1;

    while (j >= 0 && numbers_7[j] > current)
    {
        numbers_7[j + 1] = numbers_7[j];
        j--;
    }

    numbers_7[j + 1] = current;
}

for (int i = 0; i < numbers_7.Length; i++)
{
    Console.Write(numbers_7[i] + " ");
}

int[] numbers_8 = { 10, 20, 30, 40, 50 };

int sum_1 = 0;

for (int i = 0; i < numbers_8.Length; i++)
{
    sum_1 += numbers_8[i];
}

double average = (double)sum_1 / numbers_8.Length;

Console.WriteLine("Average: " + average);
//Array — Copying
int[] original = { 1, 2, 3, 4, 5 };
int[] copy = new int[original.Length];  
copy = (int[])original.Clone();
Console.WriteLine("Original: " + string.Join(", ", original));
Console.WriteLine("Copy: " + string.Join(", ", copy));
//Array — Resizing
int[] originalArray = { 1, 2, 3, 4, 5 };
Array.Resize(ref originalArray, 8);
originalArray[5] = 6;
originalArray[6] = 7;
originalArray[7] = 8;
Console.WriteLine("Resized Array: " + string.Join(", ", originalArray));
//Array — Searching
int[] searchArray = { 10, 20, 30, 40, 50 };
int searchTarget = 30;
int searchIndex = Array.IndexOf(searchArray, searchTarget);
if (searchIndex != -1)
{
    Console.WriteLine("Found at index: " + searchIndex);
}