using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var value = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return View(value);
        }

        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult Partial1()
        {
            var value = c.Blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial2()
        {
            var value = c.Blogs.Where(x => x.ID==1).Take(2).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial3()
        {
            var value = c.Blogs.OrderByDescending(x => x.ID).Take(10).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial4()
        {
            var value = c.Blogs.Take(3).ToList();
            return PartialView(value);
        }
        public PartialViewResult Partial5()
        {
            var value = c.Blogs.Take(3).OrderByDescending(x=>x.ID).ToList();
            return PartialView(value);
        }
    }
}