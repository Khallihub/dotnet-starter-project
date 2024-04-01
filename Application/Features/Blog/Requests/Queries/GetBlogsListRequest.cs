using MediatR;
using StarterProject.Application.DTOs.Blog;

namespace StarterProject.Application.Features.Blog.Requests.Queries
{
    public class GetBlogsListRequest : IRequest<List<BlogDto>>
    {
    }
}