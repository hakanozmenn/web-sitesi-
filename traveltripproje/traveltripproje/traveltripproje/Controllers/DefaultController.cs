using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveltripproje.Models.Siniflar;

namespace traveltripproje.Controllers
{
    public class DefaultController : Controller
    {
        // GET: Default
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.blogs.Take(4).ToList();
            return View(degerler);
        }
        public ActionResult About()
        {
            return View();
        }
        public PartialViewResult partial1()
        {
            var degerler = c.blogs.OrderByDescending(x => x.ID).Take(2).ToList();
            return PartialView(degerler);
        }
        public PartialViewResult partial2()
        {
            var deger = c.blogs.Where(x => x.ID==10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial3()
        {
            var deger = c.blogs.Take(10).ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial4()
        {
            var deger = c.blogs.Take(3).ToList();
            return PartialView(deger);
        }
        public PartialViewResult partial5()
        {
            var deger = c.blogs.Take(3).OrderByDescending(x => x.ID).ToList();
            return PartialView(deger);
        }
    }
}