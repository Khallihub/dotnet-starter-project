using AutoMapper;
using MediatR;
using StarterProject.Application.Contracts.Persistence;
using StarterProject.Application.DTOs.Blog;
using StarterProject.Application.Features.Blog.Requests.Queries;

namespace StarterProject.Application.Features.Blog.Handlers.Queries
{
    public class GetBlogDetailsRequestHandler : IRequestHandler<GetBlogDetailsRequest, BlogDto>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogDetailsRequestHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<BlogDto> Handle(GetBlogDetailsRequest request, CancellationToken cancellationToken)
        {
            var blog = await _blogRepository.GetBlogWithDetails(request.Id);
            return _mapper.Map<BlogDto>(blog);
        }
    }
}
