using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TravelTripProject.Models.Siniflar;

namespace TravelTripProject.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        Context context = new Context();
        public ActionResult Index()
        {
            var degerler = context.Blogs.ToList();
            return View(degerler);
        }

        [HttpGet]
        public ActionResult NewBlog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult NewBlog(Blog blog)
        {
            context.Blogs.Add(blog);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult DeleteBlog(int id)
        {
            var blog = context.Blogs.Find(id);
            context.Blogs.Remove(blog);
            context.SaveChanges();

            return RedirectToAction("Index");
        }
        public ActionResult BlogGetir(int id)
        {
            var bl = context.Blogs.Find(id);
            return View("BlogGetir",bl);
        }

        public ActionResult BlogGuncelle(Blog blog)
        {
            var blg = context.Blogs.Find(blog.ID);
            blg.Aciklama = blog.Aciklama;
            blg.Baslik = blog.Baslik;
            blg.BlogImage = blog.BlogImage;
            blg.Tarih = blog.Tarih;
            context.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult YorumListesi()
        {
            var yorumlar = context.Yorumlars.ToList();
            return View(yorumlar);
        }

        public ActionResult YorumSil(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            context.Yorumlars.Remove(yorum);
            context.SaveChanges();

            return RedirectToAction("YorumListesi");
        }

        public ActionResult YorumGetir(int id)
        {
            var yorum = context.Yorumlars.Find(id);
            return View("YorumGetir", yorum);
        }

        public ActionResult YorumGuncelle(Yorumlar y)
        {
            var yorum = context.Yorumlars.Find(y.ID);
            yorum.KullaniciAdi = y.KullaniciAdi;
            yorum.Mail = y.Mail;
            yorum.Yorum = y.Yorum;
            context.SaveChanges();
            return RedirectToAction("YorumListesi");
        }



    }
}