namespace ConsoleApp5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteSomething();
            WriteSomethingspecific("I AM A ARGUMENTAND AM  CALLING FROM A METHOD ");
            Console.ReadLine();
        }
        // access modifier(static) return type method name (parameter1, pairameter2)
        public static void WriteSomething()
        {
            Console.WriteLine(" i am called form a method");
          
        }
        public static void WriteSomethingspecific(string myText)
        {

            Console.WriteLine(myText);
          
        }
    }
}