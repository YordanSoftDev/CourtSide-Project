namespace CourtSide.Services.Core.Services
{
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using Microsoft.EntityFrameworkCore;

    public class VenueService : IVenueService
    {
        private readonly CourtSideDbContext context;

        public VenueService(CourtSideDbContext context)
        {
            this.context = context;
        }

        public async Task<IEnumerable<Venue>> GetAllVenuesAsync()
        {
            return await this.context.Venues
                .AsNoTracking()
                .ToListAsync();
        }
    }
    
}
