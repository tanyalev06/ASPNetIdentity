using Microsoft.AspNetCore.Mvc;

namespace TestIdentity.ViewModels
{
    public class EditUserViewModel : Controller
    {
        public string Id { get; set; }
        public string Email { get; set; }
        public int Year { get; set; }
    }
}
