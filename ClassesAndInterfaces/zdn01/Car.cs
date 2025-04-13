using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn01
{
    public struct Car : ITransport
    {
        public static string TransportType => "Автомобиль";
        public double RentalCostPerMinute { get; }

        public string LicensePlate { get; }
        public string Brand { get; }
        public string Model { get; }
        public string Color { get; }

        public Car(string licensePlate, string brand, string model, string color, double rentalCostPerMinute)
        {
            LicensePlate = licensePlate;
            Brand = brand;
            Model = model;
            Color = color;
            RentalCostPerMinute = rentalCostPerMinute;
        }
    }
}
