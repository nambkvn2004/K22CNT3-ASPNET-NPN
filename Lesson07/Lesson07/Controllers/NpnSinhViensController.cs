using Lesson07.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Lesson07.Controllers
{
    public class NpnSinhViensController : Controller
    {
        // GET: NpnSinhViens
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NpnEdit([Bind(Include = "NpnMaSV,NpnHoSV,NpnTenSV,NpnNgaySinh,NpnPhai,NpnPhone,NpnEmail,NpnMaKH")] npnSinhVien NpnSinhVien)
        {
            if (ModelState.IsValid)
            {
                db.Entry(NpnSinhVien).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            ViewBag.NpnMaKH = new SelectList(db.NpnKhoas, "NpnMaKH", "NpnTenKH", NpnSinhVien.NpnMaKH);
            return View(NpnSinhVien);
        }

        // GET: NpnSinhViens/Delete/5
        public ActionResult NpnDelete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            npnSinhVien NpnSinhVien = db.NpnSinhViens.Find(id);
            if (NpnSinhVien == null)
            {
                return HttpNotFound();
            }
            return View(NpnSinhVien);
        }

        // POST: NpnSinhViens/NpnDelete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            npnSinhVien NpnSinhVien = db.NpnSinhViens.Find(id);
            db.NpnSinhViens.Remove(NpnSinhVien);
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

    }
}