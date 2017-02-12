using System.Web.Mvc;
using DungeonsAndDragons.Models;
using DungeonsAndDragons_Data.Enums;
using DungeonsAndDragons_Data.Mapping;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Services;

namespace DungeonsAndDragons.Controllers
{
    public class PlayersController : BaseController
    {
        private readonly PlayerCharactersService _playersService;
        //private readonly AbilitiesService _abilitiesService;

        public PlayersController()
        {
            _playersService = new PlayerCharactersService(UnitOfWork);
        }

        public ActionResult Index(int id)
        {
            var character = _playersService.GetById(id);
            if (character == null)
            {
                return RedirectToAction("Index", "Games");
            }

            //var abilities = abilitiesService.GetByActorId(character.ActorId);

            var viewModel = new PlayerCharacterModel(character); //, abilities); 

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create(int? gameId)
        {
            if (!Request.IsAjaxRequest())
            {
                return RedirectToAction("Index");
            }

            ViewBag.GameId = gameId;
            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(PlayerCharacterModel model, int? gameId)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Create", model);
            }

            var value = model.Map<PlayerCharacterModel, PlayerCharacter>();
            var result = _playersService.Save(value, gameId);
            if (result.Type == DataResultType.Success)
            {
                return Json(new { success = true });
            }

            ModelState.AddModelError("", $"The data could not be saved: {result.FriendlyMessage}");
            return PartialView("_Create", model);
        }
    }
}