using mvc_01Ornek.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_01Ornek.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        //Controllerin default olarak çalışacak metodu
        [HttpGet]
        public ActionResult Index()
        {
            //return null;
            return View();
        }

        [HttpGet]
        public ActionResult User()
        {
            return View();
        }

        [HttpPost]
        public ActionResult User(string kullanici, string sifre)
        {
            Session["username"] = kullanici;
            ViewBag.Pass = sifre;
            return View("Goster");
        }

        [HttpGet]
        public ActionResult Product()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Product(ProductModel model)
        {
            ViewBag.urunadi = model.Name;
            ViewBag.fiyat = model.Price;
            return View("Goster");
        }

    }
}
