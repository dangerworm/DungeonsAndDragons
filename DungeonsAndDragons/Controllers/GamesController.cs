using System.Web.Mvc;
using DungeonsAndDragons_Data;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Services;

namespace DungeonsAndDragons.Controllers
{
    public class GamesController : BaseController
    {
        private GamesService _gamesService;

        public GamesController()
        {
            _gamesService = new GamesService(UnitOfWork);
        }

        public ActionResult Index()
        {
            return View();
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
        public ActionResult Create(Game model)
        {
            var result = _gamesService.Save(model);

            return Redirect(Request.Headers[11]);
        }
    }
}