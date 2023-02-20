using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    //In each of your car, truck, and suv classes

    /*Create 2 members that are specific to each class
     * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
     *
     * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
     * 
     */
    internal class Suv : ICompany , IVehicle
    {
        public bool hasSunroof { get; set; }
        public bool hasCruisControl { get; set; }    
        public string Name { get; set; }
        public string Logo { get; set; }
        public int year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set; }

        public void PrintVehicleDetails()
        {
            Console.WriteLine(hasSunroof);
            Console.WriteLine(hasCruisControl);
            Console.WriteLine(Name);
            Console.WriteLine(Logo);
            Console.WriteLine(year);
            Console.WriteLine(Make);
            Console.WriteLine(Model);
            Console.WriteLine(Color);

        }
    }
}
