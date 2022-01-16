using App.Validation;
using App.Model;
using App.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using System;
using System.Threading;

namespace App.Pages.TimeCalculator
{
    public class IndexModel : PageModel
    {
        private const string Description = "Description";
        private const string TheDateIsNotValid = "The date is not valid.";

        private readonly ITimeCalculator _timeCalculator;
        private readonly IValidator _validator;
        public IndexModel(ITimeCalculator timeCalculator, IValidator validator)
        {
            _timeCalculator = timeCalculator;
            _validator = validator;
        }

        public void OnGet()
        {
        }

        public IActionResult OnGetTimeCalculation(string date1, string date2)
        {
            var dateArray1 = date1.Split("/");
            var dateArray2 = date2.Split("/");

            SimpleDate d1;
            SimpleDate d2;

            try
            {
                d1 = new SimpleDate(int.Parse(dateArray1[0]), int.Parse(dateArray1[1]), int.Parse(dateArray1[2]));
                d2 = new SimpleDate(int.Parse(dateArray2[0]), int.Parse(dateArray2[1]), int.Parse(dateArray2[2]));
            }
            catch(Exception)
            {
                ModelState.AddModelError(
                    Description,
                    TheDateIsNotValid);
                return BadRequest(ModelState);
            };

            if(!_validator.IsValidDate(d1) || !_validator.IsValidDate(d2))
            {
                ModelState.AddModelError(
                    Description,
                    TheDateIsNotValid);
                return BadRequest(ModelState);
            }

            var dayDifference = _timeCalculator.GetDayDifference(d1, d2);
            return Content($"The difference between the two dates is: {dayDifference} day(s).");
        }
    }
}
