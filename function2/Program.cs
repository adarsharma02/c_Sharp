namespace function2
{
    internal class Program
    {
        static void Count(string input)
        {
            int characterCount = input.Length;
            Console.WriteLine($"The amount of characters is {characterCount}.");
        }

        static void Main(string[] args)
        {
            Console.Write("Enter a string: ");
            string input = Console.ReadLine();

            Count(input);
        }
    }
}
