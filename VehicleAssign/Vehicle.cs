using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssign
{
    public class Vehicle
    {

        protected string Make { get; set; }
        protected string Model { get; set; }
        protected int Year { get; set; }

        public Vehicle()
        {
            Make = "";
            Model = "";
            Year = 0;
        }

        public Vehicle(string make, string model, int year)
        {
            Make = make;
            Model = model;
            Year = year;
        }

        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}");
            Console.WriteLine($"Model: {Model}");
            Console.WriteLine($"Year: {Year}");
        }
    }
}
