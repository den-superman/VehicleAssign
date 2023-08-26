using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssign
{
    public class Boat : Vehicle
    {
        private double Length { get; set; }
        private string HullType { get; set; }

        public Boat()
        {
            Length = 0;
            HullType = "";
        }

        public Boat(string make, string model, int year, double length, string hullType)
            : base(make, model, year)
        {
            Length = length;
            HullType = hullType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Length: {Length} meters");
            Console.WriteLine($"Hull Type: {HullType}");
        }
    }
}
