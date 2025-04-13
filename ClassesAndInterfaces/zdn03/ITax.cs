using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn03
{
    public interface ITax
    {
        static string ClassNameRus { get; }
        string ProductName { get; set; }
        double Price { get; set; }
        double AddTax();
    }
}
