using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICASTusa.Controllers
{
    public class AboutController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        // GET: About
        public ActionResult Who_We_Are()
        {
            return View();
        }

        public ActionResult History_of_ICAST()
        {
            return View();
        }

        public ActionResult The_ICAST_Team()
        {
            return View();
        }

        public ActionResult The_ICAST_Board()
        {
            return View();
        }

        public ActionResult ResourceSmart_Board(){
            return View();
        }

        public ActionResult ICAST_Partners()
        {
            return View();
        }
    }
}