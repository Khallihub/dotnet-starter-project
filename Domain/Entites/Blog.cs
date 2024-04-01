using StarterProject.Domain.Common;

namespace StarterProject.Domain.Entities
{
    public class Blog : BaseDomainEntity
    {
        public int UserId { get; set; }
        public required string Title { get; set; }
        public required string Content { get; set; }
        public int TagId { get; set; }
    }
}