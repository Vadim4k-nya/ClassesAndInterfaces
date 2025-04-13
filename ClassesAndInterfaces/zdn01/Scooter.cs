using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn01
{
    public struct Scooter : ITransport
    {
        public static string TransportType => "Самокат";
        public double RentalCostPerMinute { get; }

        public string Model { get; }
        public int Year { get; }

        public Scooter(string model, int year, double rentalCostPerMinute)
        {
            Model = model;
            Year = year;
            RentalCostPerMinute = rentalCostPerMinute;
        }
    }
}
