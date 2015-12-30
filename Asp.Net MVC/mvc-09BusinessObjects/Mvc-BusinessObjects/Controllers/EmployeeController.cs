using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using BusinessLayer;

namespace Mvc_BusinessObjects.Controllers
{
    public class EmployeeController : Controller
    {
        //
        // GET: /Employee/

        public ActionResult Index()
        {
            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
            List<Employee> emplooyes = employeeBusinessLayer.Employees.ToList();
            return View(emplooyes);
        }

    }
}
