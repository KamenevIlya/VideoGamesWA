using Microsoft.EntityFrameworkCore;
using VideoGamesWA.Configuration;
using VideoGamesWA.Data.Models;

namespace VideoGamesWA.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options) { }

        public DbSet<VideoGame> VideoGames { get; set; }

        public DbSet<Genre> Genres { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new VideoGameConfiguration());
            modelBuilder.ApplyConfiguration(new GenreConfiguration());
        }
    }
}
