using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;

namespace LotusTransformation.Models

{
    public class LotusTransformationDBContext : DbContext
    {
        public LotusTransformationDBContext(DbContextOptions<LotusTransformationDBContext> options) : base(options)
        {
            Database.EnsureCreated();
        }

        public DbSet<UserInformation>? UserInformation { get; set; }

        public DbSet<LogIn>? logIns { get; set; }    
    }

    public class LotusTransformationDbContextFactory : IDesignTimeDbContextFactory<LotusTransformationDBContext>
    {
        public LotusTransformationDBContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<LotusTransformationDBContext>();
            optionsBuilder.UseSqlServer("LotusTransformationDb");

            return new LotusTransformationDBContext(optionsBuilder.Options);
        }
    }
}
