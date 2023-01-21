using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveltripproje.Models.Siniflar;

namespace traveltripproje.Controllers
{
    public class adminController : Controller
    {
        // GET: admin
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.blogs.ToList();
            return View(degerler);
        }
        [HttpGet]
        public ActionResult yeniblog()
        {
            return View();
        }
        [HttpPost]
        public ActionResult yeniblog(blog p)
        {
            c.blogs.Add(p);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult blogsil(int id)
        {
            var b = c.blogs.Find(id);
            c.blogs.Remove(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult bloggetir(int id)
        {
            var bl = c.blogs.Find(id);
            return View("bloggetir", bl);
        }
        public ActionResult blogguncelle(blog b)
        {
            var blg = c.blogs.Find(b.ID);
            blg.aciklama = b.aciklama;
            blg.baslik = b.baslik;
            blg.blogimage = b.blogimage;
            blg.tarih = b.tarih;
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult yorumyap(blog b)
        {
            c.blogs.Add(b);
            c.SaveChanges();
            return RedirectToAction("Index");
        }
        public ActionResult yorumlistesi()
        {
            var yorumlar = c.yorumlars.ToList();
            return View(yorumlar);
        }
        public ActionResult yorumsil(int id)
        {
            var b = c.yorumlars.Find(id);
            c.yorumlars.Remove(b);
            c.SaveChanges();
            return RedirectToAction("yorumlistesi");
        }
        public ActionResult yorumgetir(int id)
        {
            var yr = c.yorumlars.Find(id);
            return View("yorumgetir", yr);
        }
        public ActionResult yorumguncelle(yorumlar y)
        {
            var yrm = c.yorumlars.Find(y.ID);
            yrm.kullaniciadi = y.kullaniciadi;
            yrm.mail = y.mail;
            yrm.yorum = y.yorum;
            c.SaveChanges();
            return RedirectToAction("yorumlistesi");
        }
    }
}