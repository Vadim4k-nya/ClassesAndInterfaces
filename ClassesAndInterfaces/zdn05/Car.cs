﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn05
{
    public struct Car
    {
        public string VIN { get; set; }
        public string EngineNumber { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public string Color { get; set; }

        public string Info
        {
            get
            {
                return $"VIN: {VIN}, Двигатель: {EngineNumber}, Марка: {Brand}, Модель: {Model}, Год выпуска: {Year}, Цвет: {Color}";
            }
        }

        public string CompareEngineNumber(string actualEngineNumber)
        {
            if (EngineNumber == actualEngineNumber)
            {
                return "Номер двигателя совпадает.";
            }
            else
            {
                return $"Номер двигателя не совпадает. Ожидался: {EngineNumber}, Фактический: {actualEngineNumber}.";
            }
        }
    }
}
