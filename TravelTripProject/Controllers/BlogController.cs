using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class BlogController : Controller
    {
        // GET: Blog
        Context context = new Context();
        public ActionResult Index()
        {
            var bloglar = context.Blogs.ToList();
            return View(bloglar);
        }

        BlogYorum by = new BlogYorum();
        public ActionResult BlogDetay(int id)
        {
          // var blogBul = context.Blogs.Where(x => x.ID == id).ToList();

            by.Blogs = context.Blogs.Where(x => x.ID == id).ToList();
            return View(by);
        }
    }
}