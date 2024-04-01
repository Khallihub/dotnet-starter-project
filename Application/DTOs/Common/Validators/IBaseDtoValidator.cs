using FluentValidation;
using StarterProject.Application.DTOs.Common;

namespace Application.DTOs.Common.Validators
{
    public class IBaseDtoValidator : AbstractValidator<BaseDto>
    {
        public IBaseDtoValidator()
        {
            RuleFor(x => x.Id)
             .NotNull()
             .WithMessage("Id is required and cannot be null.");
        }
    }
}
