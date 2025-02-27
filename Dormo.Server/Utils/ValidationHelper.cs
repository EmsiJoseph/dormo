using System.ComponentModel.DataAnnotations;

namespace Dormo.Server.Utils;

public class ValidationHelper
{
    public static bool TryValidate(object model, out List<ValidationResult> validationResults)
    {
        var validationContext = new ValidationContext(model);
        validationResults = new List<ValidationResult>();
        return Validator.TryValidateObject(model, validationContext, validationResults, true);
    }
}