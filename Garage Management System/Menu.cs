using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    class Menu
    {
        String vehicle;
        public Menu(String garage) {
            vehicle = garage;
        }

        public void strat() {
            try
            {
                int num = 0;
                while (num != 13)
                {
                    Console.WriteLine("1.View Vehicles 2.Add Vehicle 3.Delete Vehicle  \n4.Select Vehicle 5.View Vehicle Options 6.Add Vehicle Options" +
                        " \n7.Remove Vehicle Options 8.View Options 9.Show Marks \n10.Show Engine Types 11.Load Garage 12.Save Garage \n13.Exit Application");
                    getChoice();

                    num = getChoice();
                    getChoiceMenu();

                    switch (num) {
                        case 1:
                            veiwVehicle();
                            break;
                        case 2:
                            addVehicle();
                            break;
                        case 3:
                            deleteVehicle();
                            break;
                        case 4:
                            selectVehicle();
                            break;
                        case 5:
                            viewVehicleOptions();
                            break;
                        case 6:
                            addVehicleOption();
                            break;
                        case 7:
                            removeVehicleOption();
                            break;
                        case 8:
                            viewOptions();
                            break;
                        case 9:
                            showMarks();
                            break;
                        case 10:
                            showEngineTypes();
                            break;
                        case 11:
                            loadGrage();
                            break;
                         case 12:
                            saveGarage();
                            break;
                        case 13:
                            saveGarage();
                            continue;


                    }

                }
            }
            catch (MenuException e) {
                Console.WriteLine(e);
            }
            catch (FormatException e) {
                Console.WriteLine("The choice entered is not a number!");
            }
        }

        public int getChoice() {
            int num = 0;
            try
            {
                num = Convert.ToInt32(Console.ReadLine());


            }
            catch (FormatException e)
            {
                Console.WriteLine("The choice entered is not a number!");
            }

            catch (Exception e)
            {
                Console.WriteLine(e);
            }


            return num;
        }

        public void getChoiceMenu() {
            try
            {
                getChoice();
            }
            catch (MenuException e)
            {
                Console.WriteLine(e);
            }
        }

        public void veiwVehicle() {
            try
            {
                Car obj = new Car();
                Truck obj1 = new Truck();
                MotorBike obj2 = new MotorBike();

                obj.displayCar();
                obj1.displayTruck();
                obj2.displayMotorBike();
            }
            catch (Exception e) {
                Console.WriteLine(e);
            }

        }

        public void addVehicle()
        {
            Car obj = new Car();
            Truck obj1 = new Truck();
            MotorBike obj2 = new MotorBike();

            int num = 0;
            try
            {
                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else {
                    if (num == 1)
                    {

                        obj.addVehicle("Car");
                    }
                    else if (num == 2) {
                        obj.addVehicle("Truck");
                    }
                    else if (num == 3)
                    {
                        obj.addVehicle("MotorBike");
                    }
                }

            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public void deleteVehicle() {
            Car obj = new Car();
            Truck obj1 = new Truck();
            MotorBike obj2 = new MotorBike();

            int num = 0;
            int id = 0;
            try
            {
                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter vehicle id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {
                    if (num == 1)
                    {


                        obj.parts.RemoveAt(id);
                    }
                    else if (num == 2)
                    {

                        obj1.partsT.RemoveAt(id);
                    }
                    else if (num == 3)
                    {



                        obj2.partsM.RemoveAt(id);

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void selectVehicle() {
            Car obj = new Car();
            Truck obj1 = new Truck();
            MotorBike obj2 = new MotorBike();

            int num = 0;
            int id = 0;
            try
            {
                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter vehicle id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {
                    if (num == 1)
                    {


                        var car = from s in obj.parts
                                  where s.id == id
                                  select s;

                        foreach (var s in car)
                            Console.WriteLine(s.id + ", " + s.make + s.price + ", " + s.vehname);

                    }
                    else if (num == 2)
                    {

                        var trk = from s in obj1.partsT
                                  where s.id == id
                                  select s;

                        foreach (var s in trk)
                            Console.WriteLine(s.id + ", " + s.make + s.price + ", " + s.vehname);


                    }
                    else if (num == 3)
                    {




                        var mb = from s in obj2.partsM
                                 where s.id == id
                                 select s;

                        foreach (var s in mb)
                            Console.WriteLine(s.id + ", " + s.make + s.price + ", " + s.vehname);


                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }

        }

        public void viewVehicleOptions() {

            Option obj = new Option();

            int num = 0;
            int id = 0;
            try
            {
                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter vehicle id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {
                    if (num == 1)
                    {

                        var op = from s in obj.partso
                                 where s.id == id
                                 select s;

                        foreach (var s in op)
                            Console.WriteLine(s.id + ", " + s.price + ", " + s.name);


                    }
                    else if (num == 2)
                    {
                        var op = from s in obj.partso
                                 where s.id == id
                                 select s;

                        foreach (var s in op)
                            Console.WriteLine(s.id + ", " + s.price + ", " + s.name);
                    }
                    else if (num == 3)
                    {



                        var op = from s in obj.partso
                                 where s.id == id
                                 select s;

                        foreach (var s in op)
                            Console.WriteLine(s.id + ", " + s.price + ", " + s.name);

                    }
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }


        }

        public void addVehicleOption() {
            Option obj = new Option();

            int num = 0;
            int id = 0;
            try
            {
                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter vehicle id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {


                    obj.addOption();

                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void removeVehicleOption() {
            Option obj = new Option();

            int num = 0;
            int id = 0;
            try
            {
                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter option id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {
                   

                        obj.partso.RemoveAt(id);
                   
                }

            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void viewOptions() {
            try
            {
                Option obj = new Option();
              

                obj.displayOptions();
          
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void showMarks() {
            try
            {

                Car obj = new Car();
                Truck obj1 = new Truck();
                MotorBike obj2 = new MotorBike();

                int num = 0;
                int id = 0;

                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter vehicle id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {
                    if (num == 1)
                    {


                        var car = from s in obj.parts
                                  where s.id == id
                                  select s;

                        foreach (var s in car)
                            Console.WriteLine(s.make);

                    }
                    else if (num == 2)
                    {

                        var trk = from s in obj1.partsT
                                  where s.id == id
                                  select s;

                        foreach (var s in trk)
                            Console.WriteLine(s.make);


                    }
                    else if (num == 3)
                    {




                        var mb = from s in obj2.partsM
                                 where s.id == id
                                 select s;

                        foreach (var s in mb)
                            Console.WriteLine(s.make);


                    }
                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void showEngineTypes() {
            try
            {

                Motor obj = new Motor();
            

                int num = 0;
                int id = 0;

                Console.WriteLine("Enter the vehicle type (1.Car 2.Truck 3.MotorBike): ");
                num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter Motor id: ");
                id = Convert.ToInt32(Console.ReadLine());

                if (num < 1 && num > 3)
                {
                    throw new FormatException("Invalid input! ");
                }
                else
                {

                        var mt = from s in obj.partsMot
                                  where s.id == id
                                  select s;

                        foreach (var s in mt)
                            Console.WriteLine(s.name + ", " + s.power);

                }
            }


            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }

        public void loadGrage()
        {
            try
            {
                Car obj = new Car();
                Truck obj1 = new Truck();
                MotorBike obj2 = new MotorBike();
                Option obj3 = new Option();
                Motor obj4 = new Motor();

                string filePath = "data.save";
                obj.saveObject(obj,filePath);
                string filePath1 = "data1.save";
                obj1.saveObject(obj1, filePath1);
                string filePath2 = "data2.save";
                obj2.saveObject(obj2, filePath2);
                string filePath3 = "data3.save";
                obj3.saveObject(obj3, filePath3);
                string filePath4 = "data4.save";
                obj4.saveObject(obj4, filePath4);


            }
            catch (Exception e) {
                Console.WriteLine(e);
            }
        }

        public void saveGarage() {
            try
            {
                Car obj = new Car();
                Truck obj1 = new Truck();
                MotorBike obj2 = new MotorBike();
                Option obj3 = new Option();
                Motor obj4 = new Motor();

                string filePath = "data.save";
                obj = obj.loadObject(filePath) as Car;
                string filePath1 = "data1.save";
                obj1 = obj1.loadObject(filePath1) as Truck;
                string filePath2 = "data2.save";
                obj2 = obj2.loadObject(filePath2) as MotorBike;
                string filePath3 = "data3.save";
                obj3 = obj3.loadObject(filePath3) as Option;
                string filePath4 = "data4.save";
                obj4 = obj4.loadObject(filePath4) as Motor;


            }
            catch (Exception e)
            {
                Console.WriteLine(e);
            }
        }



    }
}
