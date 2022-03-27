using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default

        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.Take(5).ToList();
            return View(degerler);
        }

        public ActionResult About()
        {
            return View();
        }

        public PartialViewResult Partial1()
        {
            var degerler = context.Blogs.OrderByDescending(x=>x.ID).Take(3).ToList();
            return PartialView(degerler);
        }

        public PartialViewResult Partial2()
        {
            var deger = context.Blogs.Take(10).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial3() 
        {
            var deger = context.Blogs.Take(4).ToList();
            return PartialView(deger);
        }

        public PartialViewResult Partial4()
        {
            var deger = context.Blogs.Take(4).OrderByDescending(x=>x.ID).ToList();
            return PartialView(deger);
        }




    }
}