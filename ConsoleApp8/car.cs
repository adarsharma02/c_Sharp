using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace ConsoleApp8
{
    public class car
    {
        private readonly string _name;//private fiel use for  storing data
        //constractor
        public car(string name) {
            _name = name;
            Console.WriteLine( name +" was created");
        }
        public void Drive()
        {
            Console.WriteLine(_name+"drive");
           }
        public void stop()
        {
            Console.WriteLine( _name  +"stop the car ");
        }
    }

}
