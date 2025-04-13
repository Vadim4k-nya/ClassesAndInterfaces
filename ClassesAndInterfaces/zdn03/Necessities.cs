using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn03
{
    public class Necessities : ITax, IConsoleOutput
    {
        public static string ClassNameRus => "Предметы первой необходимости";
        private string _productName;
        private double _price;

        public string ProductName
        {
            get => _productName;
            set => _productName = value;
        }

        public double Price
        {
            get => _price;
            set => _price = value;
        }

        public Necessities(string productName, double price)
        {
            _productName = productName;
            _price = price;
        }

        public double AddTax()
        {
            return Price * 1.005;
        }

        public void Print()
        {
            Console.WriteLine($"Класс: {ClassNameRus}");
            Console.WriteLine($"Название товара: {ProductName}");
            Console.WriteLine($"Стоимость без налога: {Price}");
            Console.WriteLine($"Стоимость с налогом: {AddTax()}");
            Console.WriteLine();
        }
    }
}
