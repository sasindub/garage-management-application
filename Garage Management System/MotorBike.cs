using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    class MotorBike : Vehicle
    {
        public int cylinder;
      

        public override decimal calculateTax(decimal price)
        {

            throw new NotImplementedException();

            Console.WriteLine("Enter no of cylinders: ");
            cylinder = Convert.ToInt32(Console.ReadLine());

            return Convert.ToInt32(cylinder * price);
        }


        public override void displayCar()
        {
            throw new NotImplementedException();
        }

        public override void displayMotorBike()
        {
            throw new NotImplementedException();
            foreach (MotorBike aPart in partsM)
            {
                Console.WriteLine(aPart);
            }
        }

        public override void displayOptions()
        {
            throw new NotImplementedException();
        }

        public override void displayTruck()
        {
            throw new NotImplementedException();
        }

     

        public override decimal totalPrice(decimal price, decimal tax)
        {
            throw new NotImplementedException();

            return price * tax;
        }
    }
}
