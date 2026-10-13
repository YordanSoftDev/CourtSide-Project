namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Data.Models;

    public class TournamentConfiguration : IEntityTypeConfiguration<Tournament>
    {
        public void Configure(EntityTypeBuilder<Tournament> builder)
        {
            builder.HasKey(t => t.Id);

            builder.Property(t => t.TournamentName)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(t => t.Location)
                .IsRequired(true)
                .HasMaxLength(100);

            builder.Property(t => t.StartDate)
                .IsRequired(true);

            builder.Property(t => t.EndDate)
                .IsRequired(true);

            builder.Property(t => t.TournamentType)
                .IsRequired(true)
                .HasMaxLength(50);

            builder.Property(t => t.CourtSurface)
                .IsRequired(true)
                .HasConversion<string>()
                .HasMaxLength(20);

            builder.Property(t => t.CourtEnvironment)
               .IsRequired(true)
               .HasConversion<string>()
               .HasMaxLength(20);
        }
    }
}
