using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            Car BakerCar = new Car();

            Console.WriteLine(BakerCar.model);
            Car PeteCar = new Car("Ford", "Mustang", 10, 15);
            Console.WriteLine(PeteCar.model);
            Console.WriteLine(BakerCar.model);
            PeteCar.DriveTillEmpty();
            Console.WriteLine(PeteCar.milesTraveled);
            PeteCar.FillTank();
            PeteCar.DriveXMiles(120);
            Console.WriteLine(PeteCar.milesTraveled);
            PeteCar.DriveXMiles(120);
            Console.WriteLine(PeteCar.milesTraveled);
            Console.WriteLine(BakerCar.milesTraveled);
            Console.ReadKey();
        }
    }
}
