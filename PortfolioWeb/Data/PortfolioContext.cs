using Microsoft.EntityFrameworkCore;
using PortfolioWeb.Entities;

namespace PortfolioWeb.Data
{
    public class PortfolioContext : DbContext
    {

        public PortfolioContext()
        {
            AppContext.SetSwitch("Npgsql.EnableLegacyTimestampBehavior", true);
        }

        public DbSet<UserEntity> UserEntities { get; set; }
        public DbSet<ImageEntity> ImageEntities { get; set; }
        public DbSet<VideoEntity> VideoEntities { get; set; }

        public PortfolioContext(DbContextOptions<PortfolioContext> options) : base(options)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Configure your entity mappings here
            // Example:
            // modelBuilder.Entity<UserEntity>().ToTable("Users");
        }
    }
}
