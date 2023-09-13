namespace ConsoleApp8
{
    internal class Program
    {
        static void Main(string[] args)
        {
            car audi  = new car("audi2");
            audi.Drive();

            car bmw = new car("bmw2");  
            bmw.Drive();
            Console.WriteLine("press 1 for stop the car");

            string userInput = Console.ReadLine();
           
            if (userInput == "1")
            {
               audi.stop();
                bmw.stop();
            }
            else
            {
                Console.WriteLine("car is running");
            }

         
          
            
        }
       
    }
   
}