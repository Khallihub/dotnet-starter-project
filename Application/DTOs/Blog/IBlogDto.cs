namespace StarterProject.Application.DTOs.Blog
{
    public interface IBlogDTO
    {
        public string Title { get; set; }
        public string Content { get; set; }
        public int UserId { get; set; }
        public int TagId { get; set; }


    }
}