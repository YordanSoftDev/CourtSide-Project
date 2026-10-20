namespace TennisScores.Data.Configurations
{
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Metadata.Builders;
    using TennisScores.Data.Models;

    public class VenueConfiguration : IEntityTypeConfiguration<Venue>
    {
        public static IEnumerable<Venue> DefaultVenues =>
             new List<Venue>
             {
                 new Venue
                 {
                     Id = 1,
                     Name = "All England Lawn Tennis and Croquet Club"
                 },
                 new Venue
                 {
                     Id = 2,
                     Name = "Stade Roland Garros"
                 },
                 new Venue
                 {
                     Id = 3,
                     Name = "USTA Billie Jean King National Tennis Center"
                 },
                 new Venue
                 {
                     Id = 4,
                     Name = "Almaty Arena"
                 },
                 new Venue
                 {
                     Id = 5,
                     Name = "Melbourne Park"
                 },
                 new Venue
                 {
                     Id = 6,
                     Name = "Monte-Carlo Country Club"
                 },
                 new Venue
                 {
                     Id = 7,
                     Name = "Caja Mágica"
                 },
                 new Venue
                 {
                     Id = 8,
                     Name = "Foro Italico"
                 },
                 new Venue
                 {
                     Id = 9,
                     Name = "Queen's Club"
                 },
                 new Venue
                 {
                     Id = 10,
                     Name = "St. Jakobshalle"
                 }
             };

        public void Configure(EntityTypeBuilder<Venue> builder)
        {
            builder.HasMany(v => v.TournamentVenues)
               .WithOne(tv => tv.Venue)
               .HasForeignKey(tv => tv.VenueId)
               .OnDelete(DeleteBehavior.Restrict);

            builder.HasData(DefaultVenues);
        }
    }
}
