using App.Model;

namespace App.Services
{
    public class TimeCalculator : ITimeCalculator
    {
        // To store number of days in each month.
        private readonly int[] monthDays = { 31, 28, 31,
                               30, 31, 30,
                               31, 31, 30,
                               31, 30, 31 };

        /// <summary>
        /// Calculate the total number of days between two dates.
        /// </summary>
        public int GetDayDifference(SimpleDate date1, SimpleDate date2)
        {
            // return the difference between two counts
            return (GetDays(date2) - GetDays(date1));
        }

        /// <summary>
        /// Count total number of days before the given date.
        /// </summary>
        private int GetDays(SimpleDate date)
        {
            // initialize count using years and day
            int n = date.Year * 365 + date.Day;

            // Add days for months in given date
            for (int i = 0; i < date.Month - 1; i++)
            {
                n += monthDays[i];
            }

            // Add a day for every leap year
            n += CountLeapYears(date);

            return n;
        }

        /// <summary>
        /// This method counts the number of leap years before the given date.
        /// </summary>
        static int CountLeapYears(SimpleDate d)
        {
            int years = d.Year;

            // Check if the current year needs to be considered for the count of leap years or not
            if (d.Month <= 2)
            {
                years--;
            }

            // A year is a leap year if it is a multiple of 4, multiple of 400 and not a multiple of 100. https://en.wikipedia.org/wiki/Leap_year
            return (years / 4) - (years / 100) + (years / 400);
        }
    }
}
