namespace DessisionM1
{
    internal class Program
    {
        static void Main(string[] args)
        {
        
            Console.WriteLine("what is temprature you like");
             String temprature = Console.ReadLine();
            int numTemp;
            int number;
            bool userinterNumber = int.TryParse(temprature, out number);
            if(userinterNumber) {
                numTemp = number;
            }
            else { 
            numTemp =0;
                Console.WriteLine("you value enter not a number ");
            } 
            if (numTemp<20)
            {
                Console.WriteLine("take the coat");
            }
            else if (numTemp == 20) {

                Console.WriteLine(" wear full colothes");
            }
             else  {
                Console.WriteLine("you can wear short");
            }
            Console.ReadKey();
        }
    }
}