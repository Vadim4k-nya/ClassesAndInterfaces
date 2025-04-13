using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn04
{
    public class Accounting
    {
        public double CalculateIncomeTax(ISalary employee, int days)
        {
            // Хотя параметр 'days' передается, зарплата рассчитывается на основе
            // свойства WorkingDays объекта employee.
            double salary = employee.CalculateSalary();
            return salary * 0.13; // Подоходный налог 13%
        }
    }
}
