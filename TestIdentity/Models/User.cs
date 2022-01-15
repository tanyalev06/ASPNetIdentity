using Microsoft.AspNetCore.Identity;

namespace TestIdentity.Models
{
    public class User : IdentityUser
    {
        public int Year { get; set; }
    }
}