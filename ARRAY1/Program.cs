using System;

class Program
{
    static void GetOdd(int[] numbers)
    {
        Console.WriteLine("Odd numbers:");
        foreach (int number in numbers)
        {
            if (number % 2 != 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    static void GetEven(int[] numbers)
    {
        Console.WriteLine("Even numbers:");
        foreach (int number in numbers)
        {
            if (number % 2 == 0)
            {
                Console.WriteLine(number);
            }
        }
    }

    static void Main()
    {
        int[] numbers = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

        GetOdd(numbers);
        GetEven(numbers);
    }
}
