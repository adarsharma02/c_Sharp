namespace problem1
{
    internal class Program
    {
        static string username;
        static string password;
        static void Main(string[] args)
        {
            Console.WriteLine("Thise is a logIn system");
            Register();
            login();
            Console.ReadLine();
        }
        public static void Register()
        {
            Console.WriteLine("enter your name");
            username = Console.ReadLine();
            Console.WriteLine("enter your password");
            password = Console.ReadLine();
            Console.WriteLine("Registeration is Done");
            Console.WriteLine("````````````");
        }
        public static void login()
        {
            Console.WriteLine("enter your name");
            if (username == Console.ReadLine())
            {
                Console.WriteLine("enter your password");

                if (password == Console.ReadLine())
                {
                    Console.WriteLine("login is done");
                }
                else
                {
                    Console.WriteLine("login faild");

                }
            }
            else
            {
                Console.WriteLine("login faild");

            }

        }
    }
}