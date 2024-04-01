using Application.DTOs.Common;
using Application.DTOs.Common.Validators;
using FluentValidation;
using StarterProject.Application.DTOs.Blog;
using StarterProject.Application.DTOs.Blog.Validators;

namespace Application.DTOs.CinemaDtos.Validators
{
    public class UpdateBlogValidator : AbstractValidator<UpdateBlogDto>
    {
        public UpdateBlogValidator()
        {
            Include(new IBlogDtoValidator());
            Include(new IBaseDtoValidator());
        }
    }
}
