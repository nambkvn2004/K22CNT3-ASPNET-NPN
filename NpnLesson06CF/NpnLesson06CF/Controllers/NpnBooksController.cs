using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NpnLesson06CF.Models;

namespace NpnLesson06CF.Controllers
{
    public class NpnBooksController : Controller
    {
        private NpnBookStore db = new NpnBookStore();

        // GET: NpnBooks
        public ActionResult Index()
        {
            return View(db.NpnBooks.ToList());
        }

        // GET: NpnBooks/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NpnBook npnBook = db.NpnBooks.Find(id);
            if (npnBook == null)
            {
                return HttpNotFound();
            }
            return View(npnBook);
        }

        // GET: NpnBooks/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NpnBooks/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NpnId,NpnBookID,NpnTitle,NpnAuthor,NpnYear,NpnPulisher,NpnPicture,NpnCategoryId")] NpnBook npnBook)
        {
            if (ModelState.IsValid)
            {
                db.NpnBooks.Add(npnBook);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(npnBook);
        }

        // GET: NpnBooks/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NpnBook npnBook = db.NpnBooks.Find(id);
            if (npnBook == null)
            {
                return HttpNotFound();
            }
            return View(npnBook);
        }

        // POST: NpnBooks/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NpnId,NpnBookID,NpnTitle,NpnAuthor,NpnYear,NpnPulisher,NpnPicture,NpnCategoryId")] NpnBook npnBook)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npnBook).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(npnBook);
        }

        // GET: NpnBooks/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NpnBook npnBook = db.NpnBooks.Find(id);
            if (npnBook == null)
            {
                return HttpNotFound();
            }
            return View(npnBook);
        }

        // POST: NpnBooks/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            NpnBook npnBook = db.NpnBooks.Find(id);
            db.NpnBooks.Remove(npnBook);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
