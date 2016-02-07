using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;
using PagedList;
using PagedList.Mvc;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private SampleDBContext db = new SampleDBContext();

        //
        // GET: /Home/

        public ActionResult Index(string searchBy, string search, int? page, string sortBy)
        {
            ViewBag.NameSort = String.IsNullOrEmpty(sortBy) ? "Name desc" : "";
            ViewBag.GenderSort = sortBy == "Gender" ? "Gender desc" : "Gender";

            var employees = db.Employees.AsQueryable();

            if (searchBy == "Gender")
            {
                employees = employees.Where(x => x.Gender == search || search == null);
            }
            else
            {
                employees = employees.Where(x => x.Name.StartsWith(search) || search == null);
            }

            switch (sortBy)
            {
                case "Name desc":
                    employees = employees.OrderByDescending(x => x.Name);
                    break;
                case "Gender desc":
                    employees = employees.OrderByDescending(x => x.Gender);
                    break;
                case "Gender":
                    employees = employees.OrderBy(x => x.Gender);
                    break;
                default:
                    employees = employees.OrderBy(x => x.Name);
                    break;
            }

            return View(employees.ToPagedList(page ?? 1, 3));
            /*
            if (searchBy == "Gender")
            {
                return View(db.Employees.Where(x => x.Gender == search || search == null)
                    .ToList().ToPagedList(page  ?? 1, 3));
            }
            else
            {
                return View(db.Employees.Where(emp => emp.Name.StartsWith(search) || search == null)
                    .ToList().ToPagedList(page ?? 1, 3));
            }
            */
        }
        //
        // GET: /Home/Details/5

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
        // GET: /Home/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /Home/Create

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Employees.Add(employee);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(employee);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Employee employee = db.Employees.Find(id);
            if (employee == null)
            {
                return HttpNotFound();
            }
            return View(employee);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Employee employee)
        {
            if (ModelState.IsValid)
            {
                db.Entry(employee).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(employee);
        }

        //
        // GET: /Home/Delete/5

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
        // POST: /Home/Delete/5

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