namespace catchh;
internal class Program

{
    static void Main(string[] args)
    {
        Console.WriteLine("Press any key...");
        ConsoleKeyInfo keyInfo = Console.ReadKey();

        Console.WriteLine("\nYou pressed the key: " + keyInfo.Key);
        Console.WriteLine("KeyChar: " + keyInfo.KeyChar);
        Console.WriteLine("Modifiers: " + keyInfo.Modifiers);
        Console.WriteLine("Key State: " + keyInfo.Key.ToString());
    }
}
}