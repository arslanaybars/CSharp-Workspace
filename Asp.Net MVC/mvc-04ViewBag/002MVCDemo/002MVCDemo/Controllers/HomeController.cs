using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _002MVCDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public ActionResult Index()
        {
            //return "Id : " + id + " Name : " + Request.QueryString["name"];
            //return "Id = " + id + " Name = " + name;

            ViewBag.Countries =new List<string>
            {
                "Turkey",
                "Lithuania",
                "USA",
                "Canada"
            };

            return View();

        }

        public string GetDetails()
        {
            return "GetDetails is working..";
        }

    }
}
