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

            var viewModel = character.Map<PlayerCharacter, PlayerCharacterModel>();

            return View(viewModel);
        }

        [HttpGet]
        public ActionResult Create()
        {
            if (!Request.IsAjaxRequest())
            {
                return RedirectToAction("Index");
            }

            return PartialView("_Create");
        }

        [HttpPost]
        public ActionResult Create(PlayerCharacterModel model)
        {
            if (!ModelState.IsValid)
            {
                return PartialView("_Create", model);
            }

            var value = model.Map<PlayerCharacterModel, PlayerCharacter>();
            var result = _playersService.Save(value);
            if (result.Type == DataResultType.Success)
            {
                return Json(new { success = true });
            }

            ModelState.AddModelError("", "The data could not be saved. Please try again.");
            return PartialView("_Create", model);
        }
    }
}