using App.Entities;
using App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System.Threading;

namespace App.Pages.TimeCalculator
{
    public class IndexModel : PageModel
    {
        private readonly ITimeCalculator _timeCalculator;
        public IndexModel(ITimeCalculator timeCalculator)
        {
            _timeCalculator = timeCalculator;
        }

        public void OnGet()
        {
        }

        public IActionResult OnGetTimeCalculation(string date1, string date2)
        {
            // Thread.Sleep(1000);

            var dateArray1 = date1.Split("/");
            var d1 = new SimpleDate(int.Parse(dateArray1[0]), int.Parse(dateArray1[1]), int.Parse(dateArray1[2]));

            var dateArray2 = date2.Split("/");
            var d2 = new SimpleDate(int.Parse(dateArray2[0]), int.Parse(dateArray2[1]), int.Parse(dateArray2[2]));

            var dayDifference = _timeCalculator.GetDayDifference(d1, d2);
            return Content($"The difference between the two dates is: {dayDifference} day(s).");
        }
    }
}
