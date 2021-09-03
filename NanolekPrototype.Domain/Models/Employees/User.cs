using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.EntityModels.Models
{
    public class User : IdentityUser<int>
    {
        [DisplayName("Фио")]
        public string FullName { get; set; }
        [DisplayName("Должность")]
        public string Position { get; set; }
        public ICollection<PackagingProtocol> OOK { get; set; }
        public ICollection<PackagingProtocol> TLF { get; set; }
    }
}