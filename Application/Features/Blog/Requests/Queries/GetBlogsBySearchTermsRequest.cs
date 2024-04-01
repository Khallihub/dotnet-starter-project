using MediatR;
using StarterProject.Application.DTOs.Blog;

namespace StarterProject.Application.Features.Blog.Requests.Queries
{
    public class GetBlogsBySearchTermsRequest : IRequest<List<BlogDto>>
    {
        public required string SearchTerm { get; set; }
    }
}