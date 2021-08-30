using Microsoft.EntityFrameworkCore;

namespace NanolekPrototype.Models
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<PackagingProtocol> PackagingProtocols { get; set; }
    }
}