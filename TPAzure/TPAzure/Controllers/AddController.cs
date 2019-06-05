﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TPAzure.DAO;
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

        public void Add(pub newPub)
        {
            using (DAO.adzadEntities adzadEntities = new DAO.adzadEntities())
            {
                adzadEntities.pubs.Add(newPub);
                adzadEntities.SaveChanges();

                int count = adzadEntities.pubs.Count();
            }
        }

        public ActionResult ShowAds()
        {
            adzadEntities adzadEntities = new adzadEntities();
            return View(adzadEntities.pubs.ToList());
        }
    }
}