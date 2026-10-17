namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Data.Models;

    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasMany(v => v.TournamentVenues)
               .WithOne(tv => tv.Venue)
               .HasForeignKey(tv => tv.VenueId)
               .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
