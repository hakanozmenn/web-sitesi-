using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveltripproje.Models.Siniflar;
namespace traveltripproje.Controllers
{
    public class blogController : Controller
    {
        // GET: blog
        Context c = new Context();
        blogyorum by = new blogyorum();
        public ActionResult Index()
        {
            //var bloglar = c.blogs.ToList();
            by.deger1 = c.blogs.ToList();
            by.deger3 = c.blogs.Take(3).ToList();
            return View(by);
        }
       
        public ActionResult blogdetay(int id)
        {
           // var blogbul = c.blogs.Where(x => x.ID == id).ToList();
           by.deger1=c.blogs.Where(x => x.ID == id).ToList();
            by.deger2 = c.yorumlars.Where(x => x.blogid == id).ToList();
            return View(by);
        }
        [HttpGet]
        public PartialViewResult yorumyap(int id)
        {
            ViewBag.deger = id;
            return PartialView();
        }

        [HttpPost]
        public PartialViewResult yorumyap(yorumlar y)
        {
            c.yorumlars.Add(y);
            c.SaveChanges();
            return PartialView("Index");
        }
    }
}