using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesAndInterfaces.zdn03;

namespace ClassesAndInterfaces.Demonstrations
{
    public class TaxDemo : IDemonstration
    {
        public static void Demonstration()
        {
            Necessities bread = new Necessities("Хлеб", 1.5);
            LuxuryItems diamondRing = new LuxuryItems("Бриллиантовое кольцо", 15000);

            bread.Print();
            diamondRing.Print();
        }
    }
}
