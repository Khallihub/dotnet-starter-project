using MediatR;

namespace StarterProject.Application.Features.LeaveAllocations.Requests.Commands
{
    public class DeleteBlogCommand : IRequest
    {
        public int Id { get; set; }
    }
}
