using StarterProject.Application.DTOs.Common;

namespace StarterProject.Application.DTOs.Blog
{
    public class BlogDto : BaseDto, IBlogDTO
    {
        public required string Title { get; set; }
        public required string Content { get; set; }
        public int UserId { get; set; }
        public int TagId { get; set; }
    }
}