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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(FormCollection fc)
        {
            Employee employee = new Employee();

            employee.Name = fc["Name"];
            employee.Gender = fc["Gender"];
            employee.City = fc["City"];
            employee.DateOfBirth = Convert.ToDateTime(fc["DateOfBirth"]);

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            employeeBusinessLayer.AddEmployee(employee);
            return RedirectToAction("Index");
        }

    }
}
