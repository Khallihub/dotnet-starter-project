using MediatR;
using StarterProject.Application.Contracts.Persistence;
using StarterProject.Application.Exceptions;
using StarterProject.Application.Features.LeaveAllocations.Requests.Commands;

namespace StarterProject.Application.Features.Blog.Handlers.Commands
{
    public class DeleteBlogCommandHandler : IRequestHandler<DeleteBlogCommand>
    {
        private readonly IBlogRepository _blogRepository;

        public DeleteBlogCommandHandler(IBlogRepository  blogRepository)
        {
            _blogRepository = blogRepository;       
        }
        public async Task<Unit> Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            var result = await _blogRepository.GetBlogWithDetails(request.Id);

            if (result == null)
            {
                throw new NotFoundException(nameof(result), request.Id);
            }

            await _blogRepository.Delete(result);

            return Unit.Value;
        }

        Task IRequestHandler<DeleteBlogCommand>.Handle(DeleteBlogCommand request, CancellationToken cancellationToken)
        {
            // TODO: Implement this method
           return this.Handle(request, cancellationToken);
        }
    }
}
