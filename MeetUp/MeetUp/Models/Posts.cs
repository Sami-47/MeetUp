using Microsoft.AspNetCore.Identity;

namespace MeetUp.Models
{
    public class Posts
    {
        public int Id { get; set; }
        public string? PostDescription { get; set; }
        public List<ApplicationUser>? UserName { get; set; }
    }
}
