using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using VideoGamesWA.Data.Models;

namespace VideoGamesWA.Configuration
{
    public class VideoGameConfiguration : IEntityTypeConfiguration<VideoGame>
    {
        public void Configure(EntityTypeBuilder<VideoGame> builder)
        {
            builder.ToTable("VideoGame");
            builder.Property(v => v.Name).IsRequired().HasMaxLength(50);
            builder.Property(v => v.StudioDeveloper).IsRequired().HasMaxLength(100);
            builder.Property(v => v.Genres).IsRequired();
        }
    }
}
