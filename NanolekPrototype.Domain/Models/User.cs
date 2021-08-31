using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.Domain.Models
{
    public class User : IdentityUser
    {
        public string FullName { get; set; }
        public string Position { get; set; }
    }
}