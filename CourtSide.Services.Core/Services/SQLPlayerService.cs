namespace CourtSide.Services.Core.Services
{
    using AutoMapper;
    using AutoMapper.QueryableExtensions;
    using Microsoft.EntityFrameworkCore;
    using CourtSide.Data.Models;
    using CourtSide.Data.Persistance;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Players;

    public class SQLPlayerService : IPlayerService
    {
        private readonly CourtSideDbContext context;
        private readonly IMapper mapper;

        public SQLPlayerService(CourtSideDbContext context,
        IMapper mapper)
        {
            this.context = context;
            this.mapper = mapper;
        }

        public async Task<int> CreatePlayerAsync(PlayerFormViewModel playerForm)
        {
            Player newPlayer = this.mapper.Map<Player>(playerForm);

            this.context.Players.Add(newPlayer);
            await this.context.SaveChangesAsync();

            return newPlayer.Id;
        }

        public async Task<bool> UpdatePlayerAsync(int id, PlayerFormViewModel playerForm)
        {
            Player? playerToUpdate = await this.context.Players.FindAsync(id);

            if (playerToUpdate == null)
            {
                return false;
            }

            this.mapper.Map(playerForm, playerToUpdate);

            await this.context.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeletePlayerAsync(int id)
        {
            int rowsAffected = await this.context.Players
                .Where(m => m.Id == id)
                .ExecuteDeleteAsync();

            return rowsAffected > 0;
        }

        public async Task<PlayerDetailsViewModel?> GetPlayerDetailsByIdAsync(int id)
        {
            return await this.context.Players
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerDetailsViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }
        public async Task<PlayerFormViewModel?> GetPlayerForEditByIdAsync(int id)
        {
            return await this.context.Players
                .AsNoTracking()
                .Where(m => m.Id == id)
                .ProjectTo<PlayerFormViewModel>(this.mapper.ConfigurationProvider)
                .FirstOrDefaultAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllMensPlayersForIndexAsync()
        {
            return await this.context.Players
                .Where(p=> p.Id > 1 && p.Id < 91)
                .AsNoTracking()
                .OrderBy(p => p.Rank)
                .ThenBy(p => p.Id)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }

        public async Task<IEnumerable<PlayerInfoViewModel>> GetAllWomensPlayersForIndexAsync()
        {
            return await this.context.Players
                .Where(p => p.Id > 90)
                .AsNoTracking()
                .OrderBy(p => p.Rank)
                .ThenBy(p => p.Id)
                .ProjectTo<PlayerInfoViewModel>(this.mapper.ConfigurationProvider)
                .ToListAsync();
        }
    }
}
