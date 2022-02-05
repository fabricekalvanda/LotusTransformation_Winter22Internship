using Microsoft.EntityFrameworkCore;
namespace LotusTransformation.Models

{
    public class LotusTransformationContext : DbContext
    {
        public LotusTransformationContext(DbContextOptions<LotusTransformationContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserInformation> UserInformation { get; set; }
        public DbSet<LogIn> LogIn { get; set; }
    }
}
