namespace TennisScores.Web.Controllers
{
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using TennisScores.Services.Core.Contracts;
    using TennisScores.ViewModels.Tournaments;

    public class TournamentsController : Controller
    {
        private readonly ITournamentService service;

        public TournamentsController(ITournamentService tournamentService)
        {
            this.service = tournamentService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            var tournaments = await this.service.GetAllTournamentsForIndexAsync();
            return this.View(tournaments);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var tournamentModel = await this.service.GetTournamentDetailsByIdAsync(id);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            return this.View(tournamentModel);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            var model = new TournamentFormViewModel();
            await this.service.PopulateDropdownsAsync(model);

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(TournamentFormViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                await this.service.PopulateDropdownsAsync(model);
                return this.View(model);
            }

            int createdId = await this.service.CreateTournamentAsync(model);
            return this.RedirectToAction(nameof(Details), new { id = createdId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            var model = await this.service.GetTournamentForEditByIdAsync(id);

            if (model == null)
            {
                return this.NotFound();
            }

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, TournamentFormViewModel model)
        {
            if (!this.ModelState.IsValid)
            {
                await this.service.PopulateDropdownsAsync(model);
                return this.View(model);
            }

            bool isUpdated = await this.service.UpdateTournamentAsync(id, model);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details), new { id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            var tournamentModel = await this.service.GetTournamentDetailsByIdAsync(id);

            if (tournamentModel == null)
            {
                return this.NotFound();
            }

            return this.View(tournamentModel);
        }

        [HttpPost]
        [ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isDeleted = await this.service.DeleteTournamentAsync(id);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }
    }
}