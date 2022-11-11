using Microsoft.EntityFrameworkCore;

namespace BlazorApp.Data
{
    public class KitKatDbContext : DbContext
    {
        public KitKatDbContext(DbContextOptions<KitKatDbContext> options) : base(options) {}
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            optionsBuilder.UseSqlServer(configuration.GetConnectionString("Database"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<KitKatEater>().HasData(
                new KitKatEater { Id = 1, Name ="Tomas Mortensen", NumberOfUnitPerYear = 365 }
                );
        }
        public DbSet<KitKatEater> KitKatEaters => Set<KitKatEater>();
    }
}
