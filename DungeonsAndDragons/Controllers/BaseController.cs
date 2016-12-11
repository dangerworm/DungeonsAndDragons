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
            var connectionString = $"Data Source={Environment.MachineName};Initial Catalog=DungeonsAndDragons;Integrated Security=True";

            UnitOfWork = new UnitOfWork(connectionString);
        }
    }
}