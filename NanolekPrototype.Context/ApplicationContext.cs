using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using NanolekPrototype.EntityModels.Models;

namespace NanolekPrototype.Context
{
    public class ApplicationContext : IdentityDbContext<User>
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }
        public DbSet<PackagingProtocol> PackagingProtocols { get; set; }
    }
}