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
        SampleDBContext db = new SampleDBContext();
        
        //
        // GET: /Home/
        [HttpGet]
        public ActionResult Index()
        {
            //List<Employee> Employee = db.Employee.ToList();
            return View(db.Employee.ToList());
        }

        [HttpPost]
        public ActionResult Delete(IEnumerable<int> employeeIdsToDelete)
        {
            List<Employee> employees = db.Employee.Where(x => employeeIdsToDelete.Contains(x.ID)).ToList();

            foreach (Employee employee in employees)
            {
                db.Employee.Remove(employee);
            }
            db.SaveChanges();

            return RedirectToAction("Index");
        }

    }
}
