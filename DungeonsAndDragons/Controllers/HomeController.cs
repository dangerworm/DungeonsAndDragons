using System.Web.Mvc;
using DungeonsAndDragons.Models;
using DungeonsAndDragons_Data.Services;

namespace DungeonsAndDragons.Controllers
{
    public class HomeController : BaseController
    {
        private readonly GamesService _gamesService;
        private readonly PlayerCharactersService _playerCharactersService;

        public HomeController() 
        {
            _gamesService = new GamesService(UnitOfWork);   
            _playerCharactersService = new PlayerCharactersService(UnitOfWork);
        }

        [HttpGet]
        public ActionResult Index()
        {
            var games = _gamesService.GetAll();
            var players = _playerCharactersService.GetAll();

            var viewModel = new OverviewModel(games, players);

            return View(viewModel);
        }
    }
}