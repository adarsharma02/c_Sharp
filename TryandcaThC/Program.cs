namespace TryandcaThC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("WRITE HERE  A NUMBER:");
            string userInput = Console.ReadLine();

            try
            {

                int userInputasint = int.Parse(userInput);

            }
            catch (FormatException)
            {
                Console.WriteLine(" please provide a vaild number avoid string");
            }


            catch (Exception)
            {
                Console.WriteLine(" general Expetion");
            }
            finally {
                Console.WriteLine("no worrries baby!");
                
            }
            Console.ReadKey();

        }
    }
}