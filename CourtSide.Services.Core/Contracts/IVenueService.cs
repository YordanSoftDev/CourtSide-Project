
namespace CourtSide.Services.Core.Contracts
{
    using CourtSide.Data.Models;
    public interface IVenueService
    {
        public Task<IEnumerable<Venue>> GetAllVenuesAsync();
    }
}
