// If we list all the natural numbers below 10 that are multiples of 3 or 5, we get 3, 5, 6 and 9. 
// The sum of these multiples is 23.
// Find the sum of all the multiples of 3 or 5 below 1000.

Console.Write("Input number to check sum of natural numbers below it: ");
int size = int.Parse(Console.ReadLine()!);
int sum = 0;

for (int i = 0; i < size; i++)
{
    if (i % 3 == 0 || i % 5 == 0) sum = sum + i;
}

Console.WriteLine($"The sum of natural numbers below {size} is {sum}");