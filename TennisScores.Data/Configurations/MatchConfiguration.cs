namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Data.Models;

    public class MatchConfiguration : IEntityTypeConfiguration<Match>
    {
        public void Configure(EntityTypeBuilder<Match> builder)
        {
            builder.HasOne(m => m.FirstPlayer)
                   .WithMany()
                   .HasForeignKey(m => m.FirstPlayerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.SecondPlayer)
                   .WithMany()
                   .HasForeignKey(m => m.SecondPlayerId)
                   .OnDelete(DeleteBehavior.Restrict);

            builder.Property(m => m.MatchStatus)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(m => m.MatchRound)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(m => m.CourtSurface)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.HasOne(m => m.Venue)
                .WithMany()
                .HasForeignKey(m => m.VenueId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Tournament)
                .WithMany()
                .HasForeignKey(m => m.TournamentId)
                .OnDelete(DeleteBehavior.Restrict);

            builder.HasOne(m => m.Winner)
                .WithMany()
                .HasForeignKey(m => m.WinnerId)
                .OnDelete(DeleteBehavior.Restrict);
        }

    }
}
