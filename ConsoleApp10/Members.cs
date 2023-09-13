using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp10
{
    internal class Members
    {
        //members private field
        private string memberName;
        private string jobTitle;
        private int salary;

        // member private field
        public int age;

        //member -property-expose jobTitle safely-properties statrt with a capital letter
        public string JobTitle {
            get { return jobTitle; }

            set { jobTitle = value;
             }
         }
        // public member method- can be called form other classes
        public void Introducing(bool isFriend)
        {
            if (isFriend)
            {
                sharePrivateI();
            }
            else
            {
                Console.WriteLine("may name is{0},mmmy job is{1} and i'm {2} year old .", memberName,jobTitle,age);
            }
        }
        private void sharePrivateI()
        {
            Console.WriteLine("salry is"+salary);
        }
        //members constractor
         public Members()
        {
            age = 30;
            memberName = "adarsh";
            salary = 100000000;
            jobTitle = "MERN DEV";
            Console.WriteLine("OBJ CREATED");


        }
        //member finAlizer D-estructor
        ~Members()
        {
            Console.WriteLine("DECONSTRUCTION  Of member object");
        }
    }
}
