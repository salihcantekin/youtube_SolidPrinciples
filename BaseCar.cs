using System.Net.Mail;
using SolidPrinciples.Lib.SmsModels;

namespace SolidPrinciples.Lib
{
    public abstract class BaseCar
    {
        public int TripKM { get; set; }
        
        public abstract double GetCostPerKM();
        
        
    }
}