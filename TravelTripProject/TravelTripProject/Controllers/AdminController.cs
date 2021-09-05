using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Classes;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context c = new Context();
        [Authorize]
        public ActionResult Index()
        {
            var value = c.Blogs.ToList();
            return View(value);
        }
        [HttpGet]
        public ActionResult NewBlog()
        {
          
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog b)
        {
            c.Blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var b = c.Blogs.Find(id);
            c.Blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult TakeBlog(int id)
        {
            var bl = c.Blogs.Find(id);
            return View("TakeBlog",bl);
        }
        public ActionResult UpdateBlog(Blog b)
        {
            var blg = c.Blogs.Find(b.ID);
            blg.Explanation = b.Explanation;
            blg.Title = b.Title;
            blg.BlogImage = b.BlogImage;
            blg.Date = b.Date;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult CommentList()
        {
            var comment = c.Comments.ToList();
            return View(comment);
        }
        public ActionResult DeleteComment(int id)
        {
            var b = c.Comments.Find(id);
            c.Comments.Remove(b);
            c.SaveChanges();
            return RedirectToAction("CommentList");
        }
     
    }
}