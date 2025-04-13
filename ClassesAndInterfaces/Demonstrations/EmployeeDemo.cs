using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using ClassesAndInterfaces.zdn06;

namespace ClassesAndInterfaces.Demonstrations
{
    public class EmployeeDemo : IDemonstration
    {
        public static void Demonstration()
        {
            List<Employee> employees = new List<Employee>();

            employees.Add(new Employee { LastName = "Иванов", FirstName = "Иван", MiddleName = "Иванович", Position = "Менеджер", HireYear = 2018 });
            employees.Add(new Employee { LastName = "Петров", FirstName = "Петр", MiddleName = "Петрович", Position = "Разработчик", HireYear = 2020 });
            employees.Add(new Employee { LastName = "Сидорова", FirstName = "Анна", MiddleName = "Сергеевна", Position = "Дизайнер", HireYear = 2015 });
            employees.Add(new Employee { LastName = "Кузнецов", FirstName = "Алексей", MiddleName = "Викторович", Position = "Тестировщик", HireYear = 2022 });
            employees.Add(new Employee { LastName = "Смирнова", FirstName = "Елена", MiddleName = "Андреевна", Position = "Аналитик", HireYear = 2019 });

            Console.WriteLine("Исходный список сотрудников:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Info);
            }
            Console.WriteLine();

            // Добавление нового рабатника
            Console.WriteLine("Введите данные для нового сотрудника:");
            Console.Write("Фамилия: ");
            string newLastName = Console.ReadLine();
            Console.Write("Имя: ");
            string newFirstName = Console.ReadLine();
            Console.Write("Отчество: ");
            string newMiddleName = Console.ReadLine();
            Console.Write("Должность: ");
            string newPosition = Console.ReadLine();
            Console.Write("Год принятия на работу: ");
            if (int.TryParse(Console.ReadLine(), out int newHireYear))
            {
                employees.Add(new Employee
                {
                    LastName = newLastName,
                    FirstName = newFirstName,
                    MiddleName = newMiddleName,
                    Position = newPosition,
                    HireYear = newHireYear
                });

                Console.WriteLine("\nНовый сотрудник добавлен в список.");
            }
            else
            {
                Console.WriteLine("\nНекорректный формат года принятия на работу. Сотрудник не добавлен.");
            }

            Console.WriteLine("\nСписок сотрудников после добавления:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Info);
            }
            Console.WriteLine();

            // cортировка списка по фамилии сотрудника (в порядке возрастания)
            employees = employees.OrderBy(employee => employee.LastName).ToList();

            Console.WriteLine("Список сотрудников после сортировки по фамилии:");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Info);
            }
            Console.WriteLine();

            // поиск и удаление экземпляра структуры из списка по введенным ФИО
            Console.WriteLine("Введите данные сотрудника для поиска и удаления:");
            Console.Write("Фамилия: ");
            string searchLastName = Console.ReadLine();
            Console.Write("Имя: ");
            string searchFirstName = Console.ReadLine();
            Console.Write("Отчество: ");
            string searchMiddleName = Console.ReadLine();

            Employee employeeToRemove = employees.FirstOrDefault(emp =>
                emp.LastName == searchLastName &&
                emp.FirstName == searchFirstName &&
                emp.MiddleName == searchMiddleName);

            if (employeeToRemove.LastName != null) // Проверяем, был ли найден сотрудник
            {
                employees.Remove(employeeToRemove);
                Console.WriteLine($"\nСотрудник '{searchLastName} {searchFirstName} {searchMiddleName}' найден и удален.");
            }
            else
            {
                Console.WriteLine($"\nСотрудник '{searchLastName} {searchFirstName} {searchMiddleName}' не найден.");
            }

            Console.WriteLine("\nСписок сотрудников после удаления (если был найден):");
            foreach (var employee in employees)
            {
                Console.WriteLine(employee.Info);
            }

            if (employees.Count > 0)
            {
                int currentYear = DateTime.Now.Year;
                Console.WriteLine($"\nСтаж первого сотрудника в списке ({employees[0].FirstName} {employees[0].LastName}) на {currentYear} год: {employees[0].CalculateExperience(currentYear)} лет.");
            }
        }
    }
}
