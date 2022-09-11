using Microsoft.EntityFrameworkCore;
using NBAAPP.Models;

namespace NBAAPP.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<Player> Players => Set<Player>();
        public DbSet<Game> Games => Set<Game>();
        public DbSet<Stat> Stats => Set<Stat>();
        public DbSet<Team> Teams => Set<Team>();


    }
}
