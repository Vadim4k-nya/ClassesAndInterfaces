using ClassesAndInterfaces.Demonstrations;

namespace ClassesAndInterfaces
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // аренда транспорта
            TransportRentalDemo.Demonstration();
            Console.WriteLine("\n\n\n");

            // игровой персонаж
            GameCharacterDemo.Demonstration();
            Console.WriteLine("\n\n\n");

            // налоги
            TaxDemo.Demonstration();
            Console.WriteLine("\n\n\n");

            // зарплата
            SalaryDemo.Demonstration();
            Console.WriteLine("\n\n\n");

            // машинка врум врум
            CarDemo.Demonstration();
            Console.WriteLine("\n\n\n");

            // рабыотники
            EmployeeDemo.Demonstration();
            Console.WriteLine("\n\n\n");
        }
    }
}
