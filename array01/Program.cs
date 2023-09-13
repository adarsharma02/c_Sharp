namespace array01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] bestFriends = new string[5];

            bestFriends[0] = "ravi";
            bestFriends[1] = "akash";
            bestFriends[2] = "ram";
            bestFriends[3] = "adarsh ";
            bestFriends[4] = "moksh";

           int counter = 5;
            foreach (string name in bestFriends)
            {
                Console.WriteLine("hii bhaiyo{0}", " "+name );
            }
          Console.ReadKey();

        }
    }
}