using System;
using System.Collections.Generic;
using System.Numerics;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //Create 2 Interfaces called IVehicle & ICompany

            //Create 3 classes called Car , Truck , & SUV

            //In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //Now, create objects of your 3 classes and give their members values;
            Car Car1 = new Car { Color = "Matte Black", iscompact = false, iscovertible = true, Logo = "wings", Make = "Genesis", Model = "G80",
                Name = "Genesis", year = 2023 };
            Suv suv1 = new Suv { Color= "Black", hasCruisControl = true, hasSunroof= true, Logo= "wings", Make ="Genesis", Model= "GV80",
                Name= "Genesis", year= 2023 };
            Truck truck1= new Truck { year = 2023, Name = "ford", Make ="Ford F150", Model = "Raptor", Logo = "horse", Color ="Black", 
                driveTerrain = "4WD", engineType = "V8"};

            List<IVehicle> vehicles= new List<IVehicle>();

            vehicles.Add(Car1);
            vehicles.Add(suv1);
            vehicles.Add(truck1);

            List<ICompany> company = new List<ICompany>();
            company.Add(Car1);
            company.Add(suv1);
            company.Add(truck1);



            foreach (IVehicle vehicle in vehicles )
            {
                vehicle.PrintVehicleDetails();
                Console.WriteLine();
                Console.WriteLine();
            }
            //Creatively display and organize their values

        }
    }
}
