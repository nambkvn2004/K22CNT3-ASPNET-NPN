using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NpnK22CNT3Lesson10Db.Models;

namespace NpnK22CNT3Lesson10Db.Controllers
{
    public class NpnAccountsController : Controller
    {
        private NpnK22CNT3Lesson10Entities db = new NpnK22CNT3Lesson10Entities();

        // GET: NpnAccounts
        public ActionResult Index()
        {
            return View(db.NpnAccounts.ToList());
        }

        // GET: NpnAccounts/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NpnAccount npnAccount = db.NpnAccounts.Find(id);
            if (npnAccount == null)
            {
                return HttpNotFound();
            }
            return View(npnAccount);
        }

        // GET: NpnAccounts/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: NpnAccounts/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "NpnID,NpnUserName,NpnPassword,NpnFullName,NpnEmail,NpnActive")] NpnAccount npnAccount)
        {
            if (ModelState.IsValid)
            {
                db.NpnAccounts.Add(npnAccount);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(npnAccount);
        }

        // GET: NpnAccounts/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NpnAccount npnAccount = db.NpnAccounts.Find(id);
            if (npnAccount == null)
            {
                return HttpNotFound();
            }
            return View(npnAccount);
        }

        // POST: NpnAccounts/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "NpnID,NpnUserName,NpnPassword,NpnFullName,NpnEmail,NpnActive")] NpnAccount npnAccount)
        {
            if (ModelState.IsValid)
            {
                db.Entry(npnAccount).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(npnAccount);
        }

        // GET: NpnAccounts/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            NpnAccount npnAccount = db.NpnAccounts.Find(id);
            if (npnAccount == null)
            {
                return HttpNotFound();
            }
            return View(npnAccount);
        }

        // POST: NpnAccounts/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            NpnAccount npnAccount = db.NpnAccounts.Find(id);
            db.NpnAccounts.Remove(npnAccount);
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
        //Login
        public ActionResult NpnLogin()
        {
            var NpnModel = new NpnAccount();
            return View(NpnModel); 
        }
        [HttpPost]
        public ActionResult NpnLogin(NpnAccount npnAccount)
        {
            var npnCheck = db.NpnAccounts.Where(x => x.NpnUserName.Equals(npnAccount.NpnUserName) && x.NpnPassword.Equals(npnAccount.NpnPassword)).FirstOrDefault();
                if(npnCheck !=null) 
            {
                //luu session
                Session["NpnAccount"] = npnCheck;
                return Redirect("/");
            }
            return View(npnAccount); 
        }
    }
}
