using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace App.Entities
{
    public class SimpleDate
    {
        public int Day { get; }
        public int Month { get; }
        public int Year { get; }

        public SimpleDate(int day, int month, int year)
        {
            Day = day;
            Month = month;
            Year = year;
        }
    }
}
