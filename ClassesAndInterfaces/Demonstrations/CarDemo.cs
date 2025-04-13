using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesAndInterfaces.zdn05;

namespace ClassesAndInterfaces.Demonstrations
{
    public class CarDemo : IDemonstration
    {
        public static void Demonstration()
        {
            List<Car> cars = new List<Car>();

            cars.Add(new Car { VIN = "VIN001", EngineNumber = "gwedsf", Brand = "Car1", Model = "Krutaia1", Year = 2020, Color = "Серый" });
            cars.Add(new Car { VIN = "VIN002", EngineNumber = "fewfge", Brand = "Car2", Model = "Krutaia2", Year = 2018, Color = "Синий" });
            cars.Add(new Car { VIN = "VIN003", EngineNumber = "zxcvdf", Brand = "Car3", Model = "Krutaia3", Year = 2022, Color = "Красный" });
            cars.Add(new Car { VIN = "VIN004", EngineNumber = "ewrtwe", Brand = "Car4", Model = "Krutaia4", Year = 2021, Color = "Черный" });
            cars.Add(new Car { VIN = "VIN005", EngineNumber = "werfds", Brand = "Car5", Model = "Krutaia5", Year = 2019, Color = "Белый" });

            Console.WriteLine("Исходный список автомобилей:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Info);
            }
            Console.WriteLine();

            // Добавление нового ААААВТОМОБИЛЯ
            Console.WriteLine("Введите данные для нового автомобиля:");
            Console.Write("VIN-номер двигателя: ");
            string newVIN = Console.ReadLine();
            Console.Write("Номер двигателя: ");
            string newEngineNumber = Console.ReadLine();
            Console.Write("Марка: ");
            string newBrand = Console.ReadLine();
            Console.Write("Модель: ");
            string newModel = Console.ReadLine();
            Console.Write("Год выпуска: ");
            if (int.TryParse(Console.ReadLine(), out int newYear))
            {
                Console.Write("Цвет: ");
                string newColor = Console.ReadLine();

                cars.Add(new Car
                {
                    VIN = newVIN,
                    EngineNumber = newEngineNumber,
                    Brand = newBrand,
                    Model = newModel,
                    Year = newYear,
                    Color = newColor
                });

                Console.WriteLine("\nНовый автомобиль добавлен в список.");
            }
            else
            {
                Console.WriteLine("\nНекорректный формат года выпуска. Автомобиль не добавлен.");
            }

            Console.WriteLine("\nСписок автомобилей после добавления:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Info);
            }
            Console.WriteLine();

            // Сортировка списка по увеличению года выпуска автомобиля
            cars = cars.OrderBy(car => car.Year).ToList();

            Console.WriteLine("Список автомобилей после сортировки по году выпуска:");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Info);
            }
            Console.WriteLine();

            // Поиск и удаление экземпляра структуры из списка по введенному VIN-номеру двигателя
            Console.Write("Введите VIN-номер двигателя автомобиля для поиска и удаления: ");
            string vinToDelete = Console.ReadLine();

            Car carToRemove = cars.FirstOrDefault(car => car.VIN == vinToDelete);

            if (carToRemove.VIN != null)
            {
                cars.Remove(carToRemove);
                Console.WriteLine($"\nАвтомобиль с VIN-номером '{vinToDelete}' найден и удален.");
            }
            else
            {
                Console.WriteLine($"\nАвтомобиль с VIN-номером '{vinToDelete}' не найден.");
            }

            Console.WriteLine("\nСписок автомобилей после удаления (если был найден):");
            foreach (var car in cars)
            {
                Console.WriteLine(car.Info);
            }
        }
    }
}
