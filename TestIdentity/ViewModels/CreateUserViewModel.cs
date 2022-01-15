using Microsoft.AspNetCore.Mvc;

namespace TestIdentity.ViewModels
{
    public class CreateUserViewModel
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public int Year { get; set; }
    }
}
