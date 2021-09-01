using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.EntityModels.Models
{
    public class User : IdentityUser
    {
        [DisplayName("Фио")]
        public string FullName { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
    }
}