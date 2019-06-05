using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TPAzure.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            using (DAO.adzadEntities adzadEntities = new DAO.adzadEntities())
            {
                var dsqqs = adzadEntities.pubs.ToList();
                int count = adzadEntities.pubs.Count();
            }
            return View();
        }

        public ActionResult Add()
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