using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_05ViewData_ViewBag.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            ViewData["Countries"] = new List<string>
            {
                "Turkey",
                "Lithuania",
                "USA",
                "Canada"
            };

            return View();
        }

    }
}
