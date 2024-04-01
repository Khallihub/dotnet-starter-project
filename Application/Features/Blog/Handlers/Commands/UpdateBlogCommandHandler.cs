using System.ComponentModel.DataAnnotations;
using Application.DTOs.CinemaDtos.Validators;
using AutoMapper;
using HR.LeaveManagement.Application.Features.LeaveAllocations.Requests.Commands;
using StarterProject.Application.Contracts.Persistence;

namespace StarterProject.Application.Features.Blog.Handlers.Commands
{
    public class UpdateBlogCommandHandler : IRequestHandler<UpdateBlogCommand, Unit>
    {
        private readonly IBlogRepository _blogRepository;
        private readonly IMapper _mapper;

        public UpdateCinemaCommandHandler(IBlogRepository blogRepository, IMapper mapper)
        {
            _blogRepository = blogRepository;
            _mapper = mapper;

        }

        public async Task<Unit> Handle(UpdateBlogCommand request, CancellationToken cancellationToken)
        {

            var validator = new UpdateBlogValidator();
            var validationOutcome = await validator.ValidateAsync(request.UpdateBlogDto);

            if (!validationOutcome.IsValid)
            {
                throw new ValidationException(validationOutcome);
            }

            var cinema = await _cinemaRepository.GetById(request.updateCinemaDto.Id);

           
            if (cinema == null)
            {
                throw new NotFoundException(nameof(cinema), request.updateCinemaDto.Id);
            }

            _mapper.Map(request.updateCinemaDto, cinema);

            await _cinemaRepository.Update(cinema);

            return Unit.Value;
        }
    }
}
