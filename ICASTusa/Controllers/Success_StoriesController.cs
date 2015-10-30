using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICASTusa.Controllers
{
    public class Success_StoriesController : Controller
    {
        // GET: Success_Stories
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Program_Success()
        {
            return View();
        }

        public ActionResult Case_Studies()
        {
            return View();
        }

        public ActionResult Awards()
        {
            return View();
        }

        public ActionResult Testimonials()
        {
            return View();
        }
    }
}