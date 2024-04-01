using FluentValidation;

namespace StarterProject.Application.DTOs.Blog.Validators
{
    public class CreateBlogDtoValidator : AbstractValidator<CreateBlogDto>
    {
        public CreateBlogDtoValidator()
        {
            Include(new IBlogDtoValidator());
        }
    }
}