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
    public class Car : ICompany, IVehicle
    {
        public bool iscovertible { get; set; }
        public bool iscompact { get; set; }
        public int year { get; set; }
        public string Make { get; set; }
        public string Model { get; set; }
        public string Color { get; set ; }
        public string Name { get; set; }
        public string Logo { get; set; }

        public void PrintVehicleDetails()
        {
            Console.WriteLine(iscompact);
            Console.WriteLine(iscompact);
            Console.WriteLine(year);
            Console.WriteLine(Make);
            Console.WriteLine(Model);   
            Console.WriteLine(Color);
            Console.WriteLine(Name);
            Console.WriteLine(Logo);
        }
    }
}
