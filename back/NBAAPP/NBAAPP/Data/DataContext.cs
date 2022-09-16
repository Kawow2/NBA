using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Hosting;
using NBAAPP.Models;
using System.Reflection.Emit;

namespace NBAAPP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //object a = modelBuilder.Entity<Player>().;
            onModelCreatingTablePlayers(modelBuilder);
            base.OnModelCreating(modelBuilder);
        }

        private void onModelCreatingTablePlayers(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PlayerModel>()
            .HasOne(p => p.Team)
            .WithMany(b => b.Players)
            .HasForeignKey("TeamID");
        }

        public DbSet<PlayerModel> Players => Set<PlayerModel>();
        public DbSet<GameModel> Games => Set<GameModel>();
        public DbSet<StatModel> Stats => Set<StatModel>();
        public DbSet<TeamModel> Teams => Set<TeamModel>();

        


    }
}
