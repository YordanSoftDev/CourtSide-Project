using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TennisScores.Data.Models;

namespace TennisScores.Data.Configurations
{
    public class CoachConfiguration : IEntityTypeConfiguration<Coach>
    {
        public void Configure(EntityTypeBuilder<Coach> builder)
        {
            builder.HasOne(c => c.Player)
                .WithMany()
                .HasForeignKey(c => c.PlayerId)
                .OnDelete(DeleteBehavior.Restrict); 
            
        }
    }
}
