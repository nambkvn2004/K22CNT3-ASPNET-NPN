using NpnLesson06CF.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NpnLesson06CF.Controllers
{
    public class NpnCategoriesController : Controller
    {
        private static NpnBookStore npnDb;
        public NpnCategoriesController()
        {
            npnDb=new NpnBookStore();
        }
        // GET: NpnCategories
        public ActionResult NpnIndex()
        {
            /*
             * Khởi tạo DbContext
             * EF sẽ tìm thông tin kết nối trong file machine.config của .NET Framework trên máy
             * và sau đó tạo csdl
             * */
            //NpnBookStore npnDb = new NpnBookStore();
            var npnCategories = npnDb.NpnCategories.ToList();
            return View(npnCategories);
        }

        public ActionResult NpnCreate()
        {
            var npnCategory = new NpnCategory();
            return View(npnCategory);
        }
        [HttpPost]
        public ActionResult NpnCreate(NpnCategory npnCategory)
        {
            npnDb.NpnCategories.Add(npnCategory);
            npnDb.SaveChanges();

            return RedirectToAction("NpnIndex");
        }
    }
}