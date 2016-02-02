using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcDemo.Models;
using System.Text;

namespace MvcDemo.Controllers
{
    public class HomeController : Controller
    {
        private SampleDBContext db = new SampleDBContext();

        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View(db.Comments.ToList());
        }

        //
        // GET: /Home/Details/5

        public ActionResult Details(int id = 0)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
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
        // Input validation is disabled, so the users can submit HTML
        [ValidateInput(false)]
        public ActionResult Create(Comment comment)
        {
            StringBuilder sbComments = new StringBuilder();

            // Encode the text that is coming from comments textbox
            sbComments.Append(HttpUtility.HtmlEncode(comment.Comments));

            // Only decode bold and underline tags
            sbComments.Replace("&lt;b&gt;", "<b>");
            sbComments.Replace("&lt;/b&gt;", "</b>");
            sbComments.Replace("&lt;u&gt;", "<u>");
            sbComments.Replace("&lt;/u&gt;", "</u>");
            comment.Comments = sbComments.ToString();

            // HTML encode the text that is coming from name textbox
            string strEncodedName = HttpUtility.HtmlEncode(comment.Name);
            comment.Name = strEncodedName;

            if (ModelState.IsValid)
            {
                db.Comments.Add(comment);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(comment);
        }

        //
        // GET: /Home/Edit/5

        public ActionResult Edit(int id = 0)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Home/Edit/5

        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Comment comment)
        {
            if (ModelState.IsValid)
            {
                db.Entry(comment).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(comment);
        }

        //
        // GET: /Home/Delete/5

        public ActionResult Delete(int id = 0)
        {
            Comment comment = db.Comments.Find(id);
            if (comment == null)
            {
                return HttpNotFound();
            }
            return View(comment);
        }

        //
        // POST: /Home/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Comment comment = db.Comments.Find(id);
            db.Comments.Remove(comment);
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