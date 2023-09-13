using System;

namespace Function
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("write  words for upper and lower:");
            string input = Console.ReadLine();


            string result = LowUpper(input);

            Console.WriteLine(result);  
        }
        static string LowUpper(string input)
        {

            string lowerCopy = input.ToLower();

            string upperCopy = input.ToUpper();

            return lowerCopy + upperCopy;
        }
    }
}
