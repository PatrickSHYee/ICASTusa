using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ICASTusa.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ICAST_News()
        {
            return View();
        }

        public ActionResult ICAST_Events()
        {
            return View();
        }
    }
}