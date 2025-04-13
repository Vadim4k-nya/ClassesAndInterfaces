using ClassesAndInterfaces.Demonstrations;

namespace ClassesAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {

            // я решил не награмождать одну функцию демострацичми работоспособности сразу всех заданий, поэтому раскидал их по разным файлам

            // аренда транспорта
            TransportRentalDemo.Demonstration();
            Console.WriteLine("\n\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

            // игровой персонаж
            GameCharacterDemo.Demonstration();
            Console.WriteLine("\n\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

            // налоги
            TaxDemo.Demonstration();
            Console.WriteLine("\n\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

            // зарплата
            SalaryDemo.Demonstration();
            Console.WriteLine("\n\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

            // машинка врум врум
            CarDemo.Demonstration();
            Console.WriteLine("\n\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();

            // рабыотники
            EmployeeDemo.Demonstration();
            Console.WriteLine("\n\n\nНажмите Enter для продолжения...");
            Console.ReadLine();
            Console.Clear();
        }
    }
}
