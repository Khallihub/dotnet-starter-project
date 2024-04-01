using MediatR;
using StarterProject.Application.DTOs.Blog;

namespace StarterProject.Application.Features.Blog.Requests.Queries
{
    public class GetBlogDetailsRequest : IRequest<BlogDto>
    {
        public int Id { get; set; }
    }
}
