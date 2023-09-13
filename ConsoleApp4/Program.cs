namespace ConsoleApp4l;

internal class Program
{
    static void Main(string[] args)
    {
        string myName;
        Console.Write("enter your name after enter: ");
        myName = Console.ReadLine();
        string myNameuppercase = string.Format("upper case:{0}", myName.ToUpper());

        Console.Write(myNameuppercase);
    }
}