namespace ConsoleApp9
{


    internal class Program
    {
        
        static void Main(string[] args)
        {
          Book book = new Book();   
            book.Title = "Test";
            book.pages = 500;
            book.Title = "test2";
            
           
            Console.WriteLine("Title is " + book.Title);
            Console.WriteLine("pages number is "+  book.pages);

        }
    }
}