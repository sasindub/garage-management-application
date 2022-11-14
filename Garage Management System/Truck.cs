using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    class Truck : Vehicle
    {
        public double loadingWeight;
        public double loadingVolume;
        public int noOfAxles;

      

        public override decimal calculateTax(decimal price)
        {
           
            throw new NotImplementedException();

            Console.WriteLine("Enter no of axles: ");
            noOfAxles = Convert.ToInt32(Console.ReadLine());

            return Convert.ToInt32(noOfAxles * price); 

        }

      

        public override void displayCar()
        {
            throw new NotImplementedException();
        }

        public override void displayMotorBike()
        {
            throw new NotImplementedException();
        }

        public override void displayOptions()
        {
            throw new NotImplementedException();

        }

        public override void displayTruck()
        {
            throw new NotImplementedException();
            foreach (Truck aPart in partsT)
            {
                Console.WriteLine(aPart);
            }
        }

       

        public override decimal totalPrice(decimal price, decimal tax)
        {
            throw new NotImplementedException();
            return price * tax;
        }
    }
}
