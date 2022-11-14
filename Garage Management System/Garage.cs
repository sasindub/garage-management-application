using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    interface Garage
    {
        public static String name = "Garage";

        public void addVehicle(string vehicle);
        public void display();

        public void displayCar();

        public void displayMotorBike();

        public void displayTruck();

        public void toShortVehicle();

        public void saveObject(object data, string filepath);

        public object loadObject(string filePath);

    }
}
