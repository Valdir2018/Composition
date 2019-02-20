using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Course_composicao.Entities.Enums;

namespace Course_composicao.Entities
{
    class Worker
    {
        public string Name { get; set; }
        public WorkerLevel level { get; set; }
        public double BaseSalary { get; set; }
        public Department Department { get; set; } // Associação entre classes = Composição entre objetos
        public List<HourContact> Contracts { get; set; } = new List<HourContact>(); // Lista de contrato

        public Worker()
        {

        }

        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            this.level = level;
            this.BaseSalary = baseSalary;
            Department = department;
        }

        public void AddContract(HourContact contact)
        {
            Contracts.Add(contact); // Adiciona um contrato na lista
        }
        public void RemoveContract(HourContact contact)
        {
            Contracts.Remove(contact); // Remove um contrato
        }

        public double Income(int year, int month) // Recebe como argumento o ano e mês
        {
            double sum = BaseSalary;
            foreach(HourContact contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
              
            }
            return sum;
        }
    }
}
