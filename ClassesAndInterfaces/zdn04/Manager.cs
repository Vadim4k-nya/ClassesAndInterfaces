using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesAndInterfaces.zdn04
{
    public class Manager : ISalary, IConsoleOutput
    {
        private string _employeeName;
        private int _workingDays;

        public string EmployeeName
        {
            get => _employeeName;
            set => _employeeName = value;
        }

        public int WorkingDays
        {
            get => _workingDays;
            set => _workingDays = value;
        }

        public Manager(string employeeName, int workingDays)
        {
            _employeeName = employeeName;
            _workingDays = workingDays;
        }

        public double CalculateSalary()
        {
            return WorkingDays * 1000;
        }

        public void Print()
        {
            Console.WriteLine($"Должность: Менеджер");
            Console.WriteLine($"ФИО сотрудника: {EmployeeName}");
            Console.WriteLine($"Количество рабочих дней: {WorkingDays}");
            Console.WriteLine($"Зарплата: {CalculateSalary()}");
            Console.WriteLine();
        }
    }

}
