using MediatR;
using StarterProject.Application.DTOs.Blog;
using StarterProject.Application.Responses;

namespace StarterProject.Application.Features.LeaveAllocations.Requests.Commands
{
    public class CreateBlogCommand : IRequest<BaseCommandResponse>
    {
        public required CreateBlogDto BlogDto { get; set; }
    }
}