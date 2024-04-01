using AutoMapper;
using MediatR;
using StarterProject.Application.Contracts.Persistence;
using StarterProject.Application.DTOs.Blog;
using StarterProject.Application.Features.Blog.Requests.Queries;

namespace StarterProject.Application.Features.Blog.Handlers.Queries
{
    public class GetBlogsBySearchTermsRequestHandler : IRequestHandler<GetBlogsBySearchTermsRequest, List<BlogDto>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogsBySearchTermsRequestHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }
        public async Task<List<BlogDto>> Handle(GetBlogsBySearchTermsRequest request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.Find(request.SearchTerm);
            return _mapper.Map<List<BlogDto>>(blogs);
        }
    }
}