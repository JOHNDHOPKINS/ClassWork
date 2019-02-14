using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp8
{
    public class Car
    {
        //properties
        public String make;
        public String model;
        public double milesTraveled;
        public double mpg;
        public double tankSize;
        public double gallonsOfGas;

        //constructor(s)
        public Car()
        {
            make = "Ford";
            model = "Escape";
            milesTraveled = 0;
            mpg = 24;
            tankSize = 12;
            gallonsOfGas = tankSize;
        }
        public Car(String Make, String model, double MPG, double TankSize)
        {
            make = Make;
            this.model = model;
            mpg = MPG;
            tankSize = TankSize;
            gallonsOfGas = tankSize;
            milesTraveled = 0;
        }
        //methods
        public void DriveTillEmpty()
        {
            milesTraveled = milesTraveled + mpg * gallonsOfGas;
            gallonsOfGas = 0;
        }
        public void FillTank()
        {
            gallonsOfGas = tankSize;
        }
        public void DriveXMiles(double x)
        {
            if (gallonsOfGas >= x / mpg)
            {
                //have enough
                milesTraveled = milesTraveled + x;
                gallonsOfGas = gallonsOfGas - x / mpg;
            }
            else
            {
                //didnt have enough gallons
                DriveTillEmpty();
            }

        }
    }
}
