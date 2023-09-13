namespace newProjt1
{
    internal class Program
    {
        static void Main(string[] args)
        {
           bool isAdmin = false;
            bool isRegistered = true;
            string userName = "";
            Console.WriteLine("plz enter your Username");
             userName=Console.ReadLine();
            if (isRegistered && userName != "")
            {
                Console.WriteLine(" hii there,Registered user");
                if (userName != "") 
                {
                    Console.WriteLine("hi there, " + userName);
                   
    
                }
            }
            Console.ReadKey();

        }
    }
}