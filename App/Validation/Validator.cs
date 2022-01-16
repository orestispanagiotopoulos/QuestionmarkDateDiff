using App.Model;

namespace App.Validation
{
    public class Validator : IValidator
    {
        // Basic validation that can be improved.
        public bool IsValidDate(SimpleDate date)
        {
            if(date.Month > 12 || date.Month < 1)
            {
                return false;
            }
            if(date.Day > 31 || date.Day < 1)
            {
                return false;
            }

            return true;
        }
    }
}
