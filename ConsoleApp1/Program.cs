// See https://aka.ms/new-console-template for more information
static void Main(string[] args)
{
    {
        string stringForFloat = "0.85"; // datatype should be float
        string stringForInt = "12345"; // datatype should be int

        float myFloat = float.Parse(stringForFloat);
        int myInt = int.Parse(stringForInt);

        Console.WriteLine(myInt);
        Console.WriteLine(myFloat);
        Console.Read();
    }
}