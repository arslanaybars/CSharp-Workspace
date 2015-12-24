using mvc_05ViewData_ViewBag.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_05ViewData_ViewBag.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Details()
        {
            Employee employee = new Employee()
            {
                EmployeeID = 101,
                Name = "John",
                Gender = "Male",
                City = "London"
            };

            return View(employee);
        }

    }
}
