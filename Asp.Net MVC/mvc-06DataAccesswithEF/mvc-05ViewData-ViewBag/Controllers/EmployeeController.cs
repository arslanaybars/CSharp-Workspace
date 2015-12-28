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

        public ActionResult Details(int id)
        {
            EmployeeContext employeeContext = new EmployeeContext();

            Employee employee = employeeContext.Employees.Single(emp => emp.EmployeeId == id);

            return View(employee);
        }

    }
}
