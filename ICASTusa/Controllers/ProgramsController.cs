using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICASTusa.Controllers
{
    public class ProgramsController : Controller
    {
        // GET: Programs
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Green_Certifications()
        {
            return View();
        }

        public ActionResult Training_and_Resources()
        {
            return View();
        }
    }
}