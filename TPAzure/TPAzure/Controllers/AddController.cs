using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPAzure.Models;

namespace TPAzure.Controllers
{
    public class AddController : Controller
    {
        // GET: Add
        public ActionResult Index()
        {
            
            return View();
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            //Do somthing
        }

        public void Add(Advert newAdvert)
        {
            // Add advert
        }
    }
}