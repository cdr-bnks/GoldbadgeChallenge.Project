using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10_CompanyOuting.ClassLib
{
    public enum EventType
    {
        Golf = 1,
        Bowling,
        Amusement_Park,
        Concert
    }
    public class KomodoOutings
    {
        public int NumberOfPeople { get; set; }
        public DateTime Date { get; set; }
        public double TotalCostPerPerson { get; set; }
        public double TotalCostForEvent { get; set; }


        public KomodoOutings() { }

        public KomodoOutings(int numberOfPeople, DateTime date, double totalCostPerPerson, double totalCostForEvent)
        {
            NumberOfPeople = numberOfPeople;
            Date = Date;
            TotalCostPerPerson = totalCostPerPerson;
            TotalCostForEvent = totalCostForEvent;
        }

    }

    
}
