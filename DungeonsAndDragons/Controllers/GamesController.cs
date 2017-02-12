using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Web.Mvc;
using System.Web.Mvc.Html;
using DungeonsAndDragons_Data;
using DungeonsAndDragons_Data.Enums;
using DungeonsAndDragons_Data.Models.Object;
using DungeonsAndDragons_Data.Services;

namespace DungeonsAndDragons.Controllers
{
    public class GamesController : BaseController
    {
        private readonly GamesService _gamesService;

        public GamesController()
        {
            _gamesService = new GamesService(UnitOfWork);
        }

        public ActionResult Index(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Home");
            }

            var viewModel = _gamesService.GetById(id.Value);
            ViewBag.GameId = viewModel.Id;
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
        public ActionResult Create(Game model)
        {
            var result = _gamesService.Save(model);
            if (result.Type == DataResultType.Success)
            {
                return Json(new { success = true });
            }

            ModelState.AddModelError("", $"The game could not be created: {result.FriendlyMessage}");
            return Redirect(Request.Headers["Origin"]);
        }
    }
}