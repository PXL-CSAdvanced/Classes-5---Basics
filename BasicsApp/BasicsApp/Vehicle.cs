using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicsApp
{
    public class Vehicle
    {
        private int _numberOfWheels;
        public int NumberOfWheels { get { return _numberOfWheels; } 
            set 
            {
                if (value > 0)
                    _numberOfWheels = value;
                else
                    _numberOfWheels = 4;
            } 
        }
        public string Brand { get; set; }
        public string DriverLicense { get; set; }
        private int _maxSpeed;
        public int MaxSpeed 
        {
            get { return _maxSpeed; }
            set { _maxSpeed = Math.Abs(value); } 
        }

        public string DescribeVehicle()
        {
            return $"Merk: {Brand}, Wielen: {NumberOfWheels}, Rijbewijs: {DriverLicense}, Max. Snelheid: {MaxSpeed} km/u";
        }

        public string Drive()
        {
            return "Vroooom!";
        }
    }
}
