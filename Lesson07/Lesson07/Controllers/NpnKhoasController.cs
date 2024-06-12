using Lesson07.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lesson07.Controllers
{
    public class NpnKhoasController : Controller
    {
        private object npnDb;

        // GET: NpnKhoas
        public ActionResult NpnIndex()
        {
            NpnKetNoi npnDb = new NpnKetNoi();
            var npnKhoas = npnDb.npnKhoas.ToList();
            return View(npnKhoas);
        }
        public ActionResult NpnCreate()
        {
            var npnKhoa = new npnKhoa();
            return View(npnKhoa);
        }
        [HttpPost]
        public ActionResult NpnCreate(npnKhoa NpnKhoa)
        {
            npnDb.npnKhoas.Add(npnKhoa);
            npnDb.SaveChanges();

            return RedirectToAction("NpnIndex");
        }
    }
}