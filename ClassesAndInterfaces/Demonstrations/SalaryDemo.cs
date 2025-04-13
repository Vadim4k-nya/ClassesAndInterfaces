using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesAndInterfaces.zdn04;

namespace ClassesAndInterfaces.Demonstrations
{
    public class SalaryDemo : IDemonstration
    {
        public static void Demonstration()
        {
            Manager manager = new Manager("Крутой Вувааааак", 20);
            DepartmentHead head = new DepartmentHead("Не Крутой Чувааааак", 22);
            Accounting accountant = new Accounting();

            manager.Print();
            Console.WriteLine($"Подоходный налог (менеджер): {accountant.CalculateIncomeTax(manager, manager.WorkingDays)}");
            Console.WriteLine();

            head.Print();
            Console.WriteLine($"Подоходный налог (глава отдела): {accountant.CalculateIncomeTax(head, head.WorkingDays)}");
        }
    }
}
