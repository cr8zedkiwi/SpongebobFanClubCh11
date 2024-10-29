using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SongebobFanClub.Models;

namespace SongebobFanClub.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
        public DbSet<SongebobFanClub.Models.CustomerCity>? CustomerCity { get; set; }
        public DbSet<SongebobFanClub.Models.Customer>? Customer { get; set; }
    }
}
