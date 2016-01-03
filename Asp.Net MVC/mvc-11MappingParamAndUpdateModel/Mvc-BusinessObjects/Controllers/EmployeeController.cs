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
        [ActionName("Create")]
        public ActionResult Create_Get()
        {
            return View();
        }

        [HttpPost]
        [ActionName("Create")]
        public ActionResult Create_Post()
        {
            if (ModelState.IsValid)
            {
                Employee employee = new Employee();
                UpdateModel<Employee>(employee);
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }
            return View();
        }

        /*
        [HttpPost]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();
                employeeBusinessLayer.AddEmployee(employee);

                return RedirectToAction("Index");
            }
            return View();
        }
         * */

        /*
        [HttpPost]
        public ActionResult Create(string name, string city, string gender, DateTime dateOfBirth)
        {
            Employee employee = new Employee();

            employee.Name = name;
            employee.Gender = gender;
            employee.City = city;
            employee.DateOfBirth = dateOfBirth;

            EmployeeBusinessLayer employeeBusinessLayer = new EmployeeBusinessLayer();

            employeeBusinessLayer.AddEmployee(employee);
            return RedirectToAction("Index");
        }
        */
    }
}
