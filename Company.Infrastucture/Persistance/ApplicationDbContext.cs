using Company.Domain.Entities.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;


namespace Company.Infrastucture.Persistance
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {
            //Database.Migrate();
        }
        //public DbSet<Image> Images { get; set; }
        public virtual DbSet<UserProfile> Users { get; set; }
    }
}
