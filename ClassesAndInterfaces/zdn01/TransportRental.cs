using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn01
{
    public class TransportRental<T> where T : struct, ITransport
    {
        public string ClientName { get; }
        public T Transport { get; }
        public int RentalTimeInMinutes { get; }

        public TransportRental(string clientName, T transport, int rentalTimeInMinutes)
        {
            ClientName = clientName;
            Transport = transport;
            RentalTimeInMinutes = rentalTimeInMinutes;
        }

        public string GetRentalInfo()
        {
            string transportInfo = "";
            if (Transport is Scooter scooter)
            {
                transportInfo = $"Вид транспорта: {Scooter.TransportType},\nМодель: {scooter.Model},\nГод выпуска: {scooter.Year}";
            }
            else if (Transport is Car car)
            {
                transportInfo = $"Вид транспорта: {Car.TransportType},\nГос.номер: {car.LicensePlate},\nМарка: {car.Brand},\nМодель: {car.Model},\nЦвет: {car.Color}";
            }

            return $"ФИО клиента: {ClientName},\n{transportInfo},\nСтоимость аренды за минуту: {Transport.RentalCostPerMinute}";
        }

        public double CalculateTotalCost()
        {
            return RentalTimeInMinutes * Transport.RentalCostPerMinute;
        }
    }
}
