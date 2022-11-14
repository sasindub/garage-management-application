using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    class Car : Vehicle
    {
        private int hoursePower_tax;
        public int nbDoor;
        public int nbSeat;
        public int chestSize;
        // Create a list of parts.
        public List<Car> parts = new List<Car>();

        // Create a list of parts.
        public List<Option> partso = new List<Option>();

     

      

        public override void displayCar()
        {
            foreach (Car aPart in parts)
            {
                Console.WriteLine(aPart);
            }
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
          
        
            Console.WriteLine("Enter hourse power tax: ");
            hoursePower_tax = Convert.ToInt32(Console.ReadLine());


            return price * hoursePower_tax;

        }

        public override decimal totalPrice(decimal price, decimal htax)
        {
           

            return price + htax;
        }

       
    }
}
