using Microsoft.AspNetCore.Identity;

namespace MeetUp.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string UserName { get; set;} = string.Empty;
        public string Password { get; set; } = string.Empty;
        public byte[]? ProfilePicture { get; set;}
        public List<ApplicationUser>? Followers { get; set;}
        public List<Posts>? Posts { get; set;}
    }
}
