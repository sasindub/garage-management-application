using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    class MenuException : Exception
    {
        public MenuException() {
            Console.WriteLine("The choice is not between 1 and 13");
        }
    }
}
