using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp9
{
    internal class Book
    { 
        private string _title;
        private int _pages;

        public string Title {
            get {
                return _title;
            }
            set { _title = string.IsNullOrEmpty(value) ? "unkown" : value; }
}
        public int pages {
            get { return _pages; }
            set { _pages = value < 1 ? 1 : value; }
        }



    }
}
