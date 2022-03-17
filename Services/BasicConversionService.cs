using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SandpitWPF.Services
{
    public class BasicConversionService
    {
        public double MeterstoFeet(double meters)
        {
            return meters / 3.2808399;      
        }


        public double KilogramsToPounds(double kilograms)
        {
            return kilograms / 2.20462262;
        }

        public double KilometersPerHourToMetersPerSecond(double speed)
        {
            return speed / 0.27777778;
        }
    }
}
