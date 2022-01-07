using SolidPrinciples.Lib.CustomExceptions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SolidPrinciples.Lib
{
    public class TestClass
    {
        public TestClass()
        {


            /*
            
                S ingle Responsibility Principle  (SRP) OK
                O pen-Close Principle             (OCP) OK
                L iskov Substitution Principle    (LSP) OK
                I nterface Segregation Principle  (ISP) OK
                D ependency Inversion Principle   (DIP) OK                

            */




        }

        public void CalculateTripCost()
        {
            var calculator = new FuelCostCalculator();



            var cost = calculator.Calculate(new Toyota());

            Console.WriteLine($"Total cost for this car is {cost} TL");
        }

        public void RunCars()
        {
            try
            {
                var mercedes = new MercedesBenz();
                mercedes.Go();

                mercedes.Stop();

                mercedes.SendTripInfoEmailToDriver(new DriverInfo());
            }
            catch (EngineStartException ex)
            {
                new TripInfoLogger(new GermanyLogger()).Log(ex.Message);
            }
            catch (AirPressureException ex)
            {
                new TripInfoLogger(new LocalStorageLogger()).Log(ex.Message);
            }
            catch (Exception ex)
            {
                new TripInfoLogger(new LocalServerLogger()).Log(ex.Message);
            }
        }

    }
}
