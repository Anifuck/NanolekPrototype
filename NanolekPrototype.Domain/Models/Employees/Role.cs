using Microsoft.AspNetCore.Identity;

namespace NanolekPrototype.EntityModels.Models.Employees
{
    public class Role : IdentityRole<int>
    {
        public Role(string name) : base()
        {
            this.Name = name;
        }

    }
}