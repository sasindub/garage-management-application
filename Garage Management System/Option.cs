using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    class Option : Vehicle
    {
        
        static int nextId;
        public int id;
        public string name;
        public decimal price;

        public Option() {
            id = Interlocked.Increment(ref nextId);
        
        }

    

        public void display() {
            Console.WriteLine("ID: " + id);
            Console.WriteLine("Name: " + name);
            Console.WriteLine("Price: " + price);
        }

        public override void displayCar()
        {
            throw new NotImplementedException();
        }

        public override void displayMotorBike()
        {
            throw new NotImplementedException();
        }

        public override void displayTruck()
        {
            throw new NotImplementedException();
        }

        public override void displayOptions()
        {
            throw new NotImplementedException();
            foreach (Option aPart in partso)
            {
                Console.WriteLine(aPart);
            }
        }

        public override decimal calculateTax(decimal price)
        {
            throw new NotImplementedException();
        }

        public override decimal totalPrice(decimal price, decimal tax)
        {
            throw new NotImplementedException();
        }
    }
}
