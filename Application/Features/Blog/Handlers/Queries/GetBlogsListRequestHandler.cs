using AutoMapper;
using MediatR;
using StarterProject.Application.Contracts.Persistence;
using StarterProject.Application.DTOs.Blog;
using StarterProject.Application.Features.Blog.Requests.Queries;

namespace StarterProject.Application.Features.Blog.Handlers.Queries
{
    public class GetBlogsListRequestHandler : IRequestHandler<GetBlogsListRequest, List<BlogDto>>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public GetBlogsListRequestHandler(IBlogRepository blogRepository,
             IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;
        }

        public async Task<List<BlogDto>> Handle(GetBlogsListRequest request, CancellationToken cancellationToken)
        {
            var blogs = await _blogRepository.GetAll();
            return _mapper.Map<List<BlogDto>>(blogs);
        }
    }
}
