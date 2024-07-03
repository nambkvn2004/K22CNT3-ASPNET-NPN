using NpnK22CNT3Lesson10Db.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;


namespace NpnK22CNT3Lesson10Db.Controllers
{
    public class NpnHomeController : Controller
    {
        public ActionResult NpnIndex()
        {
            //kiểu dữ liệu trong session
            if (Session["NpnAccount"] != null)
            {
                var npnAccount = Session["NpnAccount"] as NpnAccount;
                ViewBag.FullName = npnAccount.NpnFullName;
            }    
            return View();
        }

        public ActionResult NpnAbout()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult NpnContact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}