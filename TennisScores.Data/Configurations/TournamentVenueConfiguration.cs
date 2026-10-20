namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Data.Models;

    public class TournamentVenueConfiguration : IEntityTypeConfiguration<TournamentVenue>
    {
        public void Configure(EntityTypeBuilder<TournamentVenue> builder)
        {
        }
    }
}
