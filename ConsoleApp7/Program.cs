using System;

namespace ConsoleApp7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a number:");
            string number = Console.ReadLine();

            int value;
            bool isNumber = int.TryParse(number, out value);

            if (isNumber)
            {
                if (value % 2 == 0)
                {
                    Console.WriteLine("You have entered an even number.");
                }
                else
                {
                    Console.WriteLine("You have entered an odd number.");
                }
            }
            else
            {
                Console.WriteLine("You have not entered a valid number.");
            }
        }
    }
}
