using mvc_02Stock.DataModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace mvc_02Stock.Controllers
{
    public class ProductController : Controller
    {
        //
        // GET: /Product/

        StockEntities ent = new StockEntities();

        [HttpGet]
        public ActionResult Index()
        {
            List<Products> liste = ent.Products.ToList();
            return View(liste);
        }

        [HttpGet]
        public ActionResult Edit(int ID)
        {
            var degisen = (from product in ent.Products
                           where product.id == ID
                           select product).First();

            ViewBag.Kategoriler = ent.Categories.ToList();
            return View(degisen);
        }

        [HttpPost]
        public ActionResult Edit(Products model)
        {
            var degisen = (from product in ent.Products
                           where product.id == model.id
                           select product).First();

            degisen.Name = model.Name;
            degisen.CategoryID = model.CategoryID;
            degisen.Price = model.Price;
            degisen.UnitsInStock = model.UnitsInStock;

            ent.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Delete(int ID)
        {
            var silinen = (from product in ent.Products
                           where product.id == ID
                           select product).First();

            ent.Products.Remove(silinen);
            ent.SaveChanges();

            return View(silinen);
        }

        [HttpPost]
        public ActionResult Delete(Products model)
        {
            var silinen = (from product in ent.Products
                           where product.id == model.id
                           select product).First();

            ent.Products.Remove(silinen);
            ent.SaveChanges();

            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult Create()
        {
            ViewBag.Kategoriler = ent.Categories.ToList();
            return View();
        }

        [HttpPost]
        public ActionResult Create(Products model)
        {
            Products p = new Products();
            p.Name = model.Name;
            p.CategoryID = model.CategoryID;
            p.UnitsInStock = model.UnitsInStock;
            p.Price = model.Price;

            ent.Products.Add(p);
            ent.SaveChanges();

            return RedirectToAction("Index");
        }
    }
}