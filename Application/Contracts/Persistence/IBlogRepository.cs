using StarterProject.Application.DTOs.Blog;
using StarterProject.Domain.Entities;

namespace StarterProject.Application.Contracts.Persistence
{
    public interface IBlogRepository : IGenericRepository<Blog>
    {
        Task<Blog> GetBlogWithDetails(int Id);
        Task<List<Blog>> GetAllBlogs();
        Task<List<Blog>> Find(string SearchTerm);
        Task<Blog> CreateBlog(BlogDto blogDto);
        Task<bool> BlogExists(int Id);
    }
}
