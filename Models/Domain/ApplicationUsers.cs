using Microsoft.AspNetCore.Identity;

namespace NerdFlix.Models.Domain
{
    public class ApplicationUser : IdentityUser
    {
        public string Name { get; set; }
    }
}
