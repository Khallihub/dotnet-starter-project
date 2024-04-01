using FluentValidation.Results;

namespace Application.Exceptions
{
    public class ValidationException : ApplicationException
    {
        public List<string> Errors { get; set; } = new List<string>();
        public ValidationException(ValidationResult validation)
        {
            Errors = validation.Errors.Select(error => error.ErrorMessage).ToList();
        }

    }
}
