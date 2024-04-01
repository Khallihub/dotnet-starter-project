using AutoMapper;
using MediatR;
using StarterProject.Application.Contracts.Persistence;
using StarterProject.Application.DTOs.Blog.Validators;
using StarterProject.Application.Features.LeaveAllocations.Requests.Commands;
using StarterProject.Application.Responses;
using StarterProject.Domain.Entities;

namespace StarterProject.Application.Features.Blog.Handlers.Commands
{
    public class CreateBlogCommandHandler : IRequestHandler<CreateBlogCommand, BaseCommandResponse>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public CreateBlogCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<BaseCommandResponse> Handle(CreateBlogCommand request, CancellationToken cancellationToken)
        {

            var response = new BaseCommandResponse();
            var validator = new CreateBlogDtoValidator();
            var validationOutcome = await validator.ValidateAsync(request.BlogDto);

            if (!validationOutcome.IsValid)
            {
                response.Success = false;
                response.Message = "Failed to create a new blog :(";
                response.Errors = validationOutcome.Errors.Select(error => error.ErrorMessage).ToList();
            }

            var blog = _mapper.Map<Blog>(request.BlogDto);


            await _blogRepository.CreateBlog(blog);

            response.Success = true;
            response.Message = "Added a new cinema succesfully!";
            response.Id = blog.Id;

            return response;
        }
    }
}
