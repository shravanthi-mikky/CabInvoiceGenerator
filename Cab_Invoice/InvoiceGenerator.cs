using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cab_Invoice
{
    public class InvoiceGenerator
    {
        public double CostPerKm = 10;
        public int CostPerMinute = 1;
        public int MinimumFare = 5;
        public double CalculateFare()
        {
            Console.WriteLine("Please enter the Distance");
            double Distance = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Please enter the Time_in_Minutes");
            double Time_in_minutes = Convert.ToDouble(Console.ReadLine());
            double Fare = (CostPerKm * Distance) + (CostPerMinute * Time_in_minutes);
            return Math.Max(Fare, MinimumFare);
        }
    }
}
