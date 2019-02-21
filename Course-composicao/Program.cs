using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_composicao.Entities.Enums;
using Course_composicao.Entities;
using System.Globalization;

namespace Course_composicao
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter department´s name: ");
            string deptName = Console.ReadLine();
            Console.Write("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("level (JUnior/Midlevel/Senior): ");
            WorkerLevel level;
            Enum.TryParse("WorkerLevel", true, out level);

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName);
            Worker worker = new Worker(name, level, baseSalary, dept);

            Console.WriteLine("How many contracts to this worker ?");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write($"Enter #{i} contract data: ");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.WriteLine("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.WriteLine("Duration (hours):");
                int hours = int.Parse(Console.ReadLine());
                HourContact contact = new HourContact(date, valuePerHour, hours);
                worker.AddContract(contact);


            }

            Console.WriteLine();

            Console.Write("Enter month and year to calculate icome (MM/YYYY): ");
            string monthAndYear = Console.ReadLine();

            int month = int.Parse(monthAndYear.Substring(0, 2));
            // extrair o ano da string
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name:  " + worker.Name);
            Console.WriteLine("Departemnt:  " + worker.Department.Name);
            Console.WriteLine("Income for :" + monthAndYear + ": " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

            Console.ReadKey();

        }
    }
}
