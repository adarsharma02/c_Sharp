namespace ConsoleApp3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int age = 19;
            string name = "adarsh";
            string job = "developer";

            // 1. string concatination
            Console.WriteLine("string concatination");
            Console.WriteLine("my name is " + name + "my age is " + age);
            //2. string formmating 
            //string formmating using index
            Console.WriteLine("string formmating ");
            Console.WriteLine("my name is {0}, my age is {1}, and i'm,{2} " , name, age,job);
            //3. string interpulation
            // stirng interpulation is uses $ at the start which will allow us to  write our
            //variables like this{variable}
            Console.WriteLine("string formmating ");
            Console.WriteLine($"my name is {name}, my age is {age}, and i'm,{job} ");

            //4.  vervatim string 
            //vervatim string  is start with  @ and tells the compiler to take tj e string
            ///literally and ignore any spaces and escap char like \n
            Console.WriteLine(" vervatim string  ");
            Console.WriteLine(@ lore);
        }
    }
}