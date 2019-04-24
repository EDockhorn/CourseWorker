using System;
using System.Collections.Generic;
using System.Text;

namespace CourseWorker.Entities
{
    class HourContract
    {
        public DateTime Date { get; set; }
        public double valuePerHour { get; set; }
        public int Hours { get; set; }

        public HourContract()
        {

        }

        public HourContract(DateTime date, double valueperhour, int hours)
        {
            Date = date;
            valuePerHour = valueperhour;
            Hours = hours;
        }

        public double TotalValue()
        {
            return valuePerHour * Hours;
        }
    }
}
