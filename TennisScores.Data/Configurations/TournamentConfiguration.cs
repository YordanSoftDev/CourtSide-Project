namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Data.Models;

    public class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.Property(t => t.CourtSurface)
                .HasConversion<string>();

            builder.Property(t => t.CourtEnvironment)
               .HasConversion<string>();

            builder.HasMany(v => v.TournamentVenues)
           .WithOne(tv => tv.Tournament)
           .HasForeignKey(tv => tv.TournamentId)
           .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
