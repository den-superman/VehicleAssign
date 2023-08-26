using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssign
{
    public class Car : Vehicle
    {
        private string BodyType { get; set; }

        public Car()
        {
            BodyType = "";
        }

        public Car(string make, string model, int year, string bodyType)
            : base(make, model, year)
        {
            BodyType = bodyType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Body Type: {BodyType}");
        }
    }
}
