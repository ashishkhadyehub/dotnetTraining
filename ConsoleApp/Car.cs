using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    public class Car
    {
        //ctor- to create constructor
        public string Name { get; set; }

        public int VehicleId { get; set; }

        public string model;
        public Car()
        {
            model = "Mustang";
        }
        //fields
        public string Color = "Red";

        public int maxSpeed = 200;

        // method
        public void fullThrottle()   
        {
            Console.WriteLine("The car is going as fast as it can!");
        }
    }
}
