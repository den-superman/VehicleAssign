using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleAssign
{
    class Fleet
    {
        public void DisplayFleetInfo()
        {
            Car car1 = CreateCar();
            Car car2 = CreateCar();

            Airplane airplane1 = CreateAirplane();
            Airplane airplane2 = CreateAirplane();

            Boat boat1 = CreateBoat();
            Boat boat2 = CreateBoat();

            Console.WriteLine("Car 1:");
            car1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Airplane 1:");
            airplane1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Boat 1:");
            boat1.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Car 2:");
            car2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Airplane 2:");
            airplane2.DisplayInfo();
            Console.WriteLine();

            Console.WriteLine("Boat 2:");
            boat2.DisplayInfo();

        }

        private Car CreateCar()
        {
            Console.WriteLine("Enter Car Details:");
            Console.Write("Make: ");
            string make = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Body Type: ");
            string bodyType = Console.ReadLine();

            return new Car(make, model, year, bodyType);
        }

        private Airplane CreateAirplane()
        {
            Console.WriteLine("Enter Airplane Details:");
            Console.Write("Make: ");
            string make = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Number of Engines: ");
            int engines = int.Parse(Console.ReadLine());
            Console.Write("Engine Type: ");
            string engineType = Console.ReadLine();

            return new Airplane(make, model, year, engines, engineType);
        }

        private Boat CreateBoat()
        {
            Console.WriteLine("Enter Boat Details:");
            Console.Write("Make: ");
            string make = Console.ReadLine();
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Year: ");
            int year = int.Parse(Console.ReadLine());
            Console.Write("Length (in meters): ");
            double length = double.Parse(Console.ReadLine());
            Console.Write("Hull Type: ");
            string hullType = Console.ReadLine();

            return new Boat(make, model, year, length, hullType);

        }
    }
}
