using mvc_02Stock.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_02Stock.Controllers
{
    public class CategoryController : Controller
    {
        //
        // GET: /Category/

        StockEntities ent = new StockEntities();

        [HttpGet]
        public ActionResult Index()
        {
            List<Categories> liste = ent.Categories.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var degisen = (from category in ent.Categories
                           where category.id == ID
                           select category).First();
            return View(degisen);
        }

        [HttpPost]
        public ActionResult Edit(Categories model)
        {
            var degisen = (from category in ent.Categories
                           where category.id == model.id
                           select category).First();

            degisen.name = model.name;
            degisen.description = model.description;

            ent.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var silinen = (from category in ent.Categories
                           where category.id == ID
                           select category).First();
            //return View(silinen);
            ent.Categories.Remove(silinen);
            ent.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(Categories model)
        {
            Categories category = new Categories();
            category.name = model.name;
            category.description = model.description;

            ent.Categories.Add(category);
            ent.SaveChanges();
            return RedirectToAction("Index");
        }

        //[HttpPost]
        //public ActionResult Delete(Categories model)
        //{
        //    var silinen = (from category in ent.Categories
        //                   where category.id == model.id
        //                   select category).First();

        //    ent.Categories.Remove(silinen);
        //    ent.SaveChanges();

        //    return RedirectToAction("Index");
        //}
    }
}
