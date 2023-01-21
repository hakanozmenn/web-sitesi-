using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using traveltripproje.Models.Siniflar;
namespace traveltripproje.Controllers
{
    public class aboutController : Controller
    {
        // GET: about
        Context c = new Context();
        public ActionResult Index()
        {
            var degerler = c.hakkimizdas.ToList();
            return View(degerler);
        }
    }
}