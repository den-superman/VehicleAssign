using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssign
{
    public class Airplane : Vehicle
    {
        private int NoEngines { get; set; }
        private string EngineType { get; set; }

        public Airplane()
        {
            NoEngines = 0;
            EngineType = "";
        }

        public Airplane(string make, string model, int year, int noEngines, string engineType)
            : base(make, model, year)
        {
            NoEngines = noEngines;
            EngineType = engineType;
        }

        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Engines: {NoEngines}");
            Console.WriteLine($"Engine Type: {EngineType}");
        }
    }
}
