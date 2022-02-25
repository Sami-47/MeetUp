using Microsoft.AspNetCore.Identity;

namespace MeetUp.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string UserName { get; set;}
        public string Password { get; set;}
        public byte[] ProfilePicture { get; set;}
        public List<string> Followers { get; set;}

        public List<Posts> Posts { get; set;}
    }
}
