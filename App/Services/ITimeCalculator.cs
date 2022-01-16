using App.Model;

namespace App.Services
{
    public interface ITimeCalculator
    {
        int GetDayDifference(SimpleDate date1, SimpleDate date2);
    }
}
