namespace TennisScores.Services.Core.Services
{
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.EntityFrameworkCore;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using TennisScores.Data.Models;
    using TennisScores.Data.Persistance;
    using TennisScores.Services.Core.Contracts;
    using TennisScores.ViewModels.Tournaments;

    public class SQLTournamentService : ITournamentService
    {
        private readonly TennisScoresDbContext dbContext;

        public SQLTournamentService(TennisScoresDbContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public async Task<int> CreateTournamentAsync(TournamentFormViewModel tournamentForm)
        {
            var tournament = new Tournament
            {
                TournamentName = tournamentForm.TournamentName!,
                Location = tournamentForm.Location!,
                StartDate = tournamentForm.StartDate!.Value,
                EndDate = tournamentForm.EndDate!.Value,
                TournamentType = tournamentForm.TournamentType!,
                CourtSurface = tournamentForm.CourtSurface!.Value,
                CourtEnvironment = tournamentForm.CourtEnvironment!.Value
            };

            await this.dbContext.Tournaments.AddAsync(tournament);
            await this.dbContext.SaveChangesAsync();

            return tournament.Id;
        }

        public async Task<bool> UpdateTournamentAsync(int id, TournamentFormViewModel tournamentForm)
        {
            var tournament = await this.dbContext.Tournaments.FindAsync(id);

            if (tournament == null)
            {
                return false;
            }

            tournament.TournamentName = tournamentForm.TournamentName!;
            tournament.Location = tournamentForm.Location!;
            tournament.StartDate = tournamentForm.StartDate!.Value;
            tournament.EndDate = tournamentForm.EndDate!.Value;
            tournament.TournamentType = tournamentForm.TournamentType!;
            tournament.CourtSurface = tournamentForm.CourtSurface!.Value;
            tournament.CourtEnvironment = tournamentForm.CourtEnvironment!.Value;

            await this.dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<bool> DeleteTournamentAsync(int id)
        {
            var tournament = await this.dbContext.Tournaments.FindAsync(id);

            if (tournament == null)
            {
                return false;
            }

            this.dbContext.Tournaments.Remove(tournament);
            await this.dbContext.SaveChangesAsync();

            return true;
        }

        public async Task<IEnumerable<TournamentInfoViewModel>> GetAllTournamentsForIndexAsync()
        {
            return await this.dbContext.Tournaments
                .AsNoTracking()
                .OrderByDescending(t => t.StartDate)
                .Select(t => new TournamentInfoViewModel
                {
                    Id = t.Id,
                    TournamentName = t.TournamentName,
                    Location = t.Location,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    TournamentType = t.TournamentType,
                    CourtSurface = t.CourtSurface,
                    CourtEnvironment = t.CourtEnvironment
                })
                .ToListAsync();
        }

        public async Task<TournamentDetailsViewModel?> GetTournamentDetailsByIdAsync(int id)
        {
            return await this.dbContext.Tournaments
                .AsNoTracking()
                .Where(t => t.Id == id)
                .Select(t => new TournamentDetailsViewModel
                {
                    Id = t.Id,
                    TournamentName = t.TournamentName,
                    Location = t.Location,
                    StartDate = t.StartDate,
                    EndDate = t.EndDate,
                    TournamentType = t.TournamentType,
                    CourtSurface = t.CourtSurface,
                    CourtEnvironment = t.CourtEnvironment
                })
                .FirstOrDefaultAsync();
        }

        public async Task<TournamentFormViewModel?> GetTournamentForEditByIdAsync(int id)
        {
            var tournament = await this.dbContext.Tournaments
                .AsNoTracking()
                .FirstOrDefaultAsync(t => t.Id == id);

            if (tournament == null)
            {
                return null;
            }

            var formModel = new TournamentFormViewModel
            {
                TournamentName = tournament.TournamentName,
                Location = tournament.Location,
                StartDate = tournament.StartDate,
                EndDate = tournament.EndDate,
                TournamentType = tournament.TournamentType,
                CourtSurface = tournament.CourtSurface,
                CourtEnvironment = tournament.CourtEnvironment
            };

            await this.PopulateDropdownsAsync(formModel);

            return formModel;
        }

        public async Task PopulateDropdownsAsync(TournamentFormViewModel model)
        {
            model.TournamentNames = await this.dbContext.Tournaments
                .AsNoTracking()
                .Select(t => t.TournamentName)
                .Distinct()
                .OrderBy(name => name)
                .Select(name => new SelectListItem
        {
            Value = name,
            Text = name
        })
        .ToListAsync();

            model.TournamentTypes = await this.dbContext.Tournaments
                .AsNoTracking()
                .Select(t => t.TournamentType)
                .Distinct()
                .OrderBy(type => type)
                .Select(type => new SelectListItem
                {
                    Value = type,
                    Text = type
                })
                .ToListAsync();
        }
    }
}