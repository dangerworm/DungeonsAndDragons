using System.Configuration;
using System.Web.Mvc;

using DungeonsAndDragons_Data;

namespace DungeonsAndDragons.Controllers
{
    public class HomeController : Controller
    {
        private readonly UnitOfWork _unitOfWork;

        public HomeController() 
        {
            _unitOfWork = new UnitOfWork(ConfigurationManager.ConnectionStrings["DungeonsAndDragons"].ConnectionString);
        }

        public ActionResult Index()
        {
            var gameRepo = new SqlGameRepository(_unitOfWork);
            gameRepo.Get(1);

            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}