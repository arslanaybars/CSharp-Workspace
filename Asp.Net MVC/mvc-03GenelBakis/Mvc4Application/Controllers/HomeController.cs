using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Mvc4Application.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /Home/

        public string Index()
        {
            // or youn see
            // Refrences -> System.Web.Mvc -> properties -> check version
            return typeof(Controller).Assembly.GetName().Version.ToString();
        }

    }
}
