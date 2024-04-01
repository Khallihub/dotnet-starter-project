using FluentValidation;

namespace StarterProject.Application.DTOs.Blog.Validators
{
    public class IBlogDtoValidator : AbstractValidator<IBlogDTO>
    {
        public IBlogDtoValidator()
        {
            RuleFor(dto => dto.Title)
                   .NotEmpty()
                   .Length(2, 255)
                   .WithMessage("Title is required and must be between 2 and 255 characters.");

            RuleFor(dto => dto.Content)
                .NotEmpty()
                .WithMessage("Content is required.");

            RuleFor(dto => dto.UserId)
                .GreaterThan(0)
                .WithMessage("User ID must be a positive integer.");

            RuleFor(dto => dto.TagId)
                .GreaterThan(0)
                .WithMessage("Tag ID must be a positive integer.");
        }
    }
}