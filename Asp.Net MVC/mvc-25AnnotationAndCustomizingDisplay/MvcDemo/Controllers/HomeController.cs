using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            return View();
        }

        // GET: Home/Details/5
        public ActionResult Details(int id)
        {
            SampleDBContext db = new SampleDBContext();
            Employee emplooye = db.Employees.Single(x => x.Id == id);

            // Strongly type yapmadan view'de modeli kullandırır
            //ViewData["EmployeeData"] = emplooye;

            return View(emplooye);
        }

        // GET: Home/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Home/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Edit/5
        public ActionResult Edit(int id)
        {
            SampleDBContext db = new SampleDBContext();
            Employee emplooye = db.Employees.Single(x => x.Id == id);
            return View(emplooye);
        }

        // POST: Home/Edit/5
        [HttpPost]
        public ActionResult Edit(Employee employee)
        {
            try
            {
                // TODO: Add update logic here
                if(ModelState.IsValid)
                {
                    SampleDBContext db = new SampleDBContext();
                    Employee employeeFromDB = db.Employees.Single(x => x.Id == employee.Id);

                    employeeFromDB.FullName = employee.FullName;
                    employeeFromDB.Gender = employee.Gender;
                    employeeFromDB.Age = employee.Age;
                    employeeFromDB.HireDate = employee.HireDate;
                    employeeFromDB.Salary = employee.Salary;
                    employeeFromDB.PersonalWebSite = employee.PersonalWebSite;

                    UpdateModel(employeeFromDB);﻿
                    db.SaveChanges();

                    return RedirectToAction("Details", new { id = employee.Id });
                }
                return View(employee);
            }
            catch
            {
                return View();
            }
        }

        // GET: Home/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Home/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
