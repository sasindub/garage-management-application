using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Garage_Management_System
{
    abstract class Vehicle:Garage, IEquatable<Car>, IComparable<Car>
    {
        static int nextId;
        public int id { get; protected set; }
        public string vehname;
        public decimal price;
        public string make;
        public string vtype;

        // Create a list of parts.
        public List<Car> parts = new List<Car>();

       public  List<Truck> partsT = new List<Truck>();

        public List<MotorBike> partsM = new List<MotorBike>();

        // Create a list of parts.
        public List<Option> partso = new List<Option>();

        public List<Motor> partsMot = new List<Motor>();


        public Vehicle()
        {
            id = Interlocked.Increment(ref nextId);

        }

        public void addVehicle(string vehicle) {
            //car
            if (vehicle == "Car") {
                vtype = "Car";
               

                string vname;
                decimal price;
                int power;
                string makev;
                string istrue = "y";
                while (istrue == "y")
                {
                    if (istrue == "y")
                    {
                        Motor obj = new Motor();
                        Car obj2 = new Car();

                        Console.WriteLine("Enter Vehicle Name: ");
                        vname = Console.ReadLine();

                        Console.WriteLine("Enter Price: ");
                        price = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Engine Power: ");
                        obj.power = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Engine Name: ");
                        obj.name = Console.ReadLine();

                        Console.WriteLine("Enter Make of the vehicle: ");
                        makev = Console.ReadLine();

                        addOption();




                        // Add parts to the list.
                        parts.Add(new Car() { id = id, vehname = vname, make = makev, price = obj2.totalPrice(price, obj2.calculateTax(price))});
                        partsMot.Add(new Motor() { name = obj.name, power = obj.power });


                        Console.WriteLine("do you want add more? (y/n)");
                        istrue = Console.ReadLine();
                    }

                    else
                    {
                        break;
                    }


                }


            }

            //truck

            if (vehicle == "Truck")
            {
                vtype = "Truck";
               
                string vname;
                decimal price;
                string makev;
                string istrue = "y";
                while (istrue == "y")
                {
                    if (istrue == "y")
                    {
                        Motor obj = new Motor();
                        Truck obj2 = new Truck();

                        Console.WriteLine("Enter Vehicle: ");
                        vname = Console.ReadLine();

                        Console.WriteLine("Enter Price: ");
                        price = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Power: ");
                        obj.power = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Make of the vehicle: ");
                        makev = Console.ReadLine();

                        addOption();




                        // Add parts to the list.
                        partsT.Add(new Truck() { id = id, vehname = vname, make = makev, price = obj2.totalPrice(price, obj2.calculateTax(price: price)) });


                        Console.WriteLine("do you want add more? (y/n)");
                        istrue = Console.ReadLine();
                    }

                    else
                    {
                        break;
                    }


                }


            }

            //MotorBike
            if (vehicle == "MotorBike")
            {
                vtype = "MotorBike";
               
                string vname;
                decimal price;
                string makev;
                string istrue = "y";
                while (istrue == "y")
                {
                    if (istrue == "y")
                    {
                        Motor obj = new Motor();
                        MotorBike obj2 = new MotorBike();

                        Console.WriteLine("Enter Vehicle: ");
                        vname = Console.ReadLine();

                        Console.WriteLine("Enter Price: ");
                        price = Convert.ToDecimal(Console.ReadLine());

                        Console.WriteLine("Enter Power: ");
                        obj.power = Convert.ToInt32(Console.ReadLine());

                        Console.WriteLine("Enter Make of the vehicle: ");
                        makev = Console.ReadLine();

                        addOption();




                        // Add parts to the list.
                        partsM.Add(new MotorBike() { id = id, vehname = vname, make = makev, price = obj2.totalPrice(price, obj2.calculateTax(price: price)) });


                        Console.WriteLine("do you want add more? (y/n)");
                        istrue = Console.ReadLine();
                    }

                    else
                    {
                        break;
                    }


                }


            }
        }


        public void display() {
            if (vtype == "Car")
            {
                foreach (Car aPart in parts)
                {
                    Console.WriteLine(aPart);
                }
            }

            if (vtype == "Truck")
            {
                foreach (Truck aPart in partsT)
                {
                    Console.WriteLine(aPart);
                }
            }

            if (vtype == "MotorBike")
            {
                foreach (MotorBike aPart in partsM)
                {
                    Console.WriteLine(aPart);
                }
            }
        }

        public void toShortVehicle() {

            if (vtype == "Car")
            {
                parts.Sort(delegate (Car x, Car y)
                {
                    if (x.price == null && y.price == null) return 0;
                    else if (x.price == null) return -1;
                    else if (y.price == null) return 1;
                    else return x.price.CompareTo(y.price);
                });

               
                foreach (Car aPart in parts)
                {
                    Console.WriteLine(aPart);
                }
            }

            if (vtype == "Truck")
            {
                partsT.Sort(delegate (Truck x, Truck y)
            {
                if (x.price == null && y.price == null) return 0;
                else if (x.price == null) return -1;
                else if (y.price == null) return 1;
                else return x.price.CompareTo(y.price);
            });

                
                foreach (Car aPart in parts)
                {
                    Console.WriteLine(aPart);
                }
            }

            if (vtype == "MotorBike")
            {
                partsM.Sort(delegate (MotorBike x, MotorBike y)
                {
                    if (x.price == null && y.price == null) return 0;
                    else if (x.price == null) return -1;
                    else if (y.price == null) return 1;
                    else return x.price.CompareTo(y.price);
                });

                Console.WriteLine("\nAfter sort by name:");
                foreach (Car aPart in parts)
                {
                    Console.WriteLine(aPart);
                }
            }
        }
        

        public void addOption() {
            string istrue = "y";
            while (istrue == "y")
            {
                Option obj = new Option();
                if (istrue == "y")
                {
                    Console.WriteLine("Enter Option: ");
                    obj.name = Console.ReadLine();

                    Console.WriteLine("Enter Option Price: ");
                    obj.price = Convert.ToDecimal(Console.ReadLine());





                    // Add parts to the list.
                    partso.Add(new Option() { name = obj.name, price = obj.price, id = obj.id });


                    Console.WriteLine("do you want add more? (y/n) ");
                    istrue = Console.ReadLine();
                }

                else
                {
                    break;
                }


            }
        }


        public bool Equals(Car other)
        {
            throw new NotImplementedException();
            if (other == null) return false;
            return (this.price.Equals(other.price));
        }

        public int CompareTo(Car other)
        {
            throw new NotImplementedException();
            if (other == null)
                return 1;

            else
                return this.price.CompareTo(other.price);
        }

        public override int GetHashCode()
        {
            return (int)price;
        }



        public abstract decimal calculateTax(decimal price);

        public abstract decimal totalPrice(decimal price, decimal tax);

        public abstract void displayCar();

        public abstract void displayMotorBike();

        public abstract void displayTruck();

        public abstract void displayOptions();

        public void saveObject(object data, string filepath)
        {
            FileStream filestream;
            BinaryFormatter bf = new BinaryFormatter();

            if (File.Exists(filepath)) 
                File.Delete(filepath);


            filestream = File.Create(filepath);
            bf.Serialize(filestream,data);
            filestream.Close();
        }

        public object loadObject(string filePath)
        {
            object obj = null;
            FileStream fileStream;
            BinaryFormatter bf = new BinaryFormatter();
            if (File.Exists(filePath))
            {
                fileStream = File.OpenRead(filePath);
                obj = bf.Deserialize(fileStream);
                fileStream.Close();
                    
            }

            return obj;
        }
    }
}
