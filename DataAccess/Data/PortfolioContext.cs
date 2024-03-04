using DataAccess.Entities;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
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

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseNpgsql($"Server=localhost;Port=5432;Database=Portfolio;User Id=postgres;Password=shokhzod99;");
        }
    }
}
