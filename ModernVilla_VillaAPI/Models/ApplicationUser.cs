using Microsoft.AspNetCore.Identity;

namespace ModernVilla_VillaAPI.Models
{
    public class ApplicationUser: IdentityUser
    {
        public string Name { get; set; }
    }
}
