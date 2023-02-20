using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{

    //In your IVehicle

    /* Create 4 members that Car, Truck, & SUV all have in common.
     * Example: All vehicles have a number of wheels... for now..
     */
    internal interface IVehicle
    {
        public int year { get; set; }
        public string Make { get; set; } 
        public string Model { get; set; }    
        public string Color { get; set; }
        public void PrintVehicleDetails();

    }
}
