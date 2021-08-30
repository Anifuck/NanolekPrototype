using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Protocols;
using NanolekPrototype.Models;
using System.Configuration;
using Microsoft.Extensions.Configuration;

namespace NanolekPrototype.Initializers
{
    public class RoleInitializer
    {
        public static async Task InitializeAsync(IConfiguration configuration, UserManager<User> userManager, RoleManager<IdentityRole> roleManager)
        {
            var adminEmail = configuration.GetSection("InitializationSettings").GetSection("AdminUserEmail").Value;
            var adminPassword = configuration.GetSection("InitializationSettings").GetSection("AdminUserPassword").Value;

            if (await roleManager.FindByNameAsync("admin") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("admin"));
            }
            if (await roleManager.FindByNameAsync("controller") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("controller"));
            }
            if (await roleManager.FindByNameAsync("executor") == null)
            {
                await roleManager.CreateAsync(new IdentityRole("executor"));
            }
            if (await userManager.FindByNameAsync(adminEmail) == null)
            {
                User admin = new User { Email = adminEmail, UserName = adminEmail};
                IdentityResult result = await userManager.CreateAsync(admin, adminPassword);
                if (result.Succeeded)
                {
                    await userManager.AddToRoleAsync(admin, "admin");
                }
            }
        }
    }
}