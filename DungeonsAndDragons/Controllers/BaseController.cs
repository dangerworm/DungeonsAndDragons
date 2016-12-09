using System.Configuration;
using System.Web.Mvc;
using DungeonsAndDragons_Data;

namespace DungeonsAndDragons.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UnitOfWork UnitOfWork;

        public BaseController()
        {
            var connectionString = ConfigurationManager.ConnectionStrings["DungeonsAndDragons"].ConnectionString;
            UnitOfWork = new UnitOfWork(connectionString);
        }
    }
}