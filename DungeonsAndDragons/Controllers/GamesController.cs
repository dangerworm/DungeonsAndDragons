﻿using System.Web.Mvc;
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

            return Redirect(Request.Headers["Origin"]);
        }
    }
}