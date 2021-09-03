using System.Collections.Generic;
using Microsoft.AspNetCore.Identity;
using NanolekPrototype.EntityModels.Models;
using NanolekPrototype.EntityModels.Models.Employees;

namespace NanolekPrototype.ViewModels
{
    public class ChangeRoleViewModel
    {
        public int UserId { get; set; }
        public string UserEmail { get; set; }
        public List<Role> AllRoles { get; set; }
        public IList<string> UserRoles { get; set; }
        public ChangeRoleViewModel()
        {
            AllRoles = new List<Role>();
            UserRoles = new List<string>();
        }
    }
}