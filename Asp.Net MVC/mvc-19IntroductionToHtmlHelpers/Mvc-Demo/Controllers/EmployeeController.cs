using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Mvc_Demo.Models;

namespace Mvc_Demo.Controllers
{
    public class EmployeeController : Controller
    {
        private EmployeeContext db = new EmployeeContext();

        //
        // GET: /Employee/

        public ActionResult Index()
        {
            var employees = db.Employees.Include(e => e.Department);
            return View("~/Views/Employee/Index.cshtml", employees.ToList());
        }

        public ActionResult EmployeesByDepartment()
        {
            var departmentsTotal = db.Employees.Include(e => e.Department)
                              .GroupBy(x => x.Department.Name)
                              .Select(y => new DepartmentTotals 
                              { 
                                Name = y.Key,
                                Total = y.Count()
                              }).ToList().OrderByDescending(y => y.Total);

            return View(departmentsTotal);
        }

        //
        // GET: /Employee/Details/5

        public ActionResult Details(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // GET: /Employee/Create

        public ActionResult Create()
        {
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name");
            return View();
        }

        //
        // POST: /Employee/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if(string.IsNullOrEmpty(employee.Name))
            {
                ModelState.AddModelError("Name", "The Name Field Required");
            }

            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", employee.DepartmentId);
            return View(employee);
        }

        //
        // GET: /Employee/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", employee.DepartmentId);
            return View(employee);
        }

        //
        // POST: /Employee/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Exclude = "Name")]Employee employee)
        {
            Employee employeeFromDb = db.Employees.Single(x => x.EmployeeId == employee.EmployeeId);
           
            employeeFromDb.EmployeeId = employee.EmployeeId;
            employeeFromDb.Gender = employee.Gender;
            employeeFromDb.City = employee.City;
            employeeFromDb.DepartmentId = employee.DepartmentId;

            employee.Name = employeeFromDb.Name;

            if (ModelState.IsValid)
            {
                db.Entry(employeeFromDb).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.DepartmentId = new SelectList(db.Departments, "Id", "Name", employee.DepartmentId);
            return View(employee);
        }

        //
        // GET: /Employee/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Employee/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Employee employee = db.Employees.Find(id);
            db.Employees.Remove(employee);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}