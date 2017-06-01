using System.Configuration;
using System.Web.Mvc;
using DungeonsAndDragons_Data;
using System;

namespace DungeonsAndDragons.Controllers
{
    public class BaseController : Controller
    {
        protected readonly UnitOfWork UnitOfWork;

        public BaseController()
        {
            //var connectionString = ConfigurationManager.ConnectionStrings["DungeonsAndDragons"].ConnectionString;

            var server = Environment.MachineName;
            if (server == "PS-LT-085")
            {
                server = "SQLTEST\\DEV";
            }

            var connectionString = $"Data Source={server};Initial Catalog=DungeonsAndDragons;Integrated Security=True";

            UnitOfWork = new UnitOfWork(connectionString);
        }
    }
}