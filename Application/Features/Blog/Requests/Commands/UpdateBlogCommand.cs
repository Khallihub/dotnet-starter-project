using MediatR;
using StarterProject.Application.DTOs.Blog;

namespace HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands
{
    public class UpdateBlogCommand : IRequest<Unit>
    {
        public required UpdateBlogDto UpdateBlogDto { get; set; }
    }
}
