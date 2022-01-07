using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib
{
    public class FuelCostCalculator
    {
        public double Calculate(BaseCar car)
        {
            return car.TripKM * car.GetCostPerKM();
        }
    }
}
