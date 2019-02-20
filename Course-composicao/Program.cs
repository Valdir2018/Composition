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
            Enum.TryParse("WorkerLevel", true, out level).(Console.ReadLine());

            Console.Write("Base Salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

        }
    }
}
