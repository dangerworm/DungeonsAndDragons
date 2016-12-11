using System.Web.Mvc;
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

        public ActionResult Index(int? id)
        {
            var viewModel = _playersService.GetAll();
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
        public ActionResult Create(PlayerCharacter model)
        {
            var result = _playersService.Save(model);

            return Redirect(Request.Headers["Origin"]);
        }
    }
}