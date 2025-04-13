using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesAndInterfaces.zdn01;

namespace ClassesAndInterfaces.Demonstrations
{
    public class TransportRentalDemo : IDemonstration
    {
        public static void Demonstration()
        {
            Scooter scooter1 = new Scooter("Самокатик (сам катит)", 2023, 15000.15);
            TransportRental<Scooter> rental1 = new TransportRental<Scooter>("Гаврюша", scooter1, 30);
            Console.WriteLine(rental1.GetRentalInfo());
            Console.WriteLine($"Полная стоимость аренды: {rental1.CalculateTotalCost()} руб.\n");

            Car car1 = new Car("gwppkeg", "Machine", "v2", "Голубой", 1000);
            TransportRental<Car> rental2 = new TransportRental<Car>("v1", car1, 60);
            Console.WriteLine(rental2.GetRentalInfo());
            Console.WriteLine($"Полная стоимость аренды: {rental2.CalculateTotalCost()} руб.");
        }
    }
}
