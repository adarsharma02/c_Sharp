using System;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            string stringForFloat = "0.85"; // datatype should be float
            string stringForInt = "12345"; // datatype should be int

            float myFloat = float.Parse(stringForFloat);
            int myInt = int.Parse(stringForInt);

            Console.WriteLine(myInt);
            Console.WriteLine(myFloat);

            // Add this line to prevent the console from closing immediately
            Console.ReadLine();
        }
    }
}
