using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Management_System
{

    class Motor : Vehicle
    {
        static int nextId;
        public int id { get; protected set; }
        public string name;
        public int power;

        public Motor() {
            id = Interlocked.Increment(ref nextId);
     
        }

        public void display()
        {
            foreach (Motor aPart in partsMot)
            {
                Console.WriteLine(aPart);
            }
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
