using App.Model;

namespace App.Validation
{
    public interface IValidator
    {
        bool IsValidDate(SimpleDate date);
    }
}
