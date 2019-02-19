using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course_composicao.Entities
{
    class HourContact
    {
        public DateTime Date { get; set; }
        public double ValuePerHour  { get; set; }
        public int Hours { get; set; }

        public HourContact()
        {
            // Construtor padrao
        }

        public HourContact(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return Hours * ValuePerHour;
        }
    }
}
