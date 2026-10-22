namespace CourtSide.Web.Controllers
{
    using Microsoft.AspNetCore.Authorization;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using CourtSide.Common.MatchEnumerations;
    using CourtSide.Services.Core.Contracts;
    using CourtSide.ViewModels.Matches;

    public class MatchesController : BaseController
    {
        private readonly IMatchService service;

        public MatchesController(IMatchService service)
        {
            this.service = service;
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Index()
        {
            string? userId = this.GetUserId();

            IEnumerable<MatchInfoViewModel> matches = await
                this.service.GetAllMatchesForIndexAsync();

            return this.View(matches);
        }

        [HttpGet]
        [AllowAnonymous]
        public async Task<IActionResult> Details(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            MatchDetailsViewModel? matchDetails = await
                this.service.GetMatchDetailsByIdAsync(id);

            if (matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpGet]
        public async Task<IActionResult> Create()
        {
            IEnumerable<CourtSide.ViewModels.Players.PlayerSelectViewModel>? players = await this
                .service.GetPlayersForSelectAsync();
            MatchFormViewModel? model = new MatchFormViewModel
            {
                Players = players
                .Select(p => new SelectListItem
                {
                    Value = p.Id.ToString(),
                    Text = p.FullName
                })
            };

            return this.View(model);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(MatchFormViewModel matchForm)
        {
            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;

            if (isCompleted && !matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner must be selected when " +
                    "the match status is Completed.");
            }

            if (!isCompleted && matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner can only be assigned " +
                    "if the match status is Completed.");
            }


            if (!this.ModelState.IsValid)
            {
                return this.View(matchForm);
            }

            int createdMatchId = await this.service
                .CreateMatchAsync(matchForm);

            return this.RedirectToAction(nameof(Details),
                new { id = createdMatchId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            MatchFormViewModel? matchForm = await this.service
                .GetMatchForEditByIdAsync(id);

            if (matchForm == null)
            {
                return this.NotFound();
            }

            return this.View(matchForm);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, MatchFormViewModel matchForm)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            bool isCompleted = matchForm.MatchStatus == MatchStatus.Completed;

            if (isCompleted && !matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner must be selected when the match status is Completed.");
            }

            if (!isCompleted && matchForm.WinnerId.HasValue)
            {
                this.ModelState.AddModelError(nameof(matchForm.WinnerId),
                    "A winner can only be assigned if the match status is Completed.");
            }

            if (!this.ModelState.IsValid)
            {
                return this.View(matchForm);
            }

            bool isUpdated = await this.service.UpdateMatchAsync(id, matchForm);

            if (!isUpdated)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Details),
                new { id = id });
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            if (id <= 0)
            {
                return this.BadRequest();
            }

            MatchDetailsViewModel? matchDetails = await this.service
                .GetMatchDetailsByIdAsync(id);

            if (matchDetails == null)
            {
                return this.NotFound();
            }

            return this.View(matchDetails);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            bool isDeleted = await this.service.DeleteMatchAsync(id);

            if (!isDeleted)
            {
                return this.NotFound();
            }

            return this.RedirectToAction(nameof(Index));
        }
    }
}
