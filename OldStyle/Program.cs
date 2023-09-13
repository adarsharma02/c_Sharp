using System.Runtime.CompilerServices;

namespace OldStyle
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string name = "adarsh";
            string message = "this is my name" + name;
            string capitalnumber = message.ToUpper();
            Console.Write(capitalnumber);

            //impicit conversion
            int num = 13213;
            long bignum = 12344455;

            float myFloat = 12.34f;
            double myNewdouble = myFloat;
            double myDouble = 12.34;
            int myInt;
           // Explicit conversip0n

            myInt = (int)myDouble;


            //type conversion

            string myString = myDouble.ToString();//"12.34"
            Console.Write(myString);
            Console.Read();
        }
    }
}