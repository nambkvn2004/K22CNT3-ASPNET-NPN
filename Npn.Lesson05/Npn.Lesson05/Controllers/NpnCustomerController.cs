using Npn.Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Npn.Lesson05.Controllers
{
    public class NpnCustomerController : Controller
    {
        // GET: NpnCustomer
        public ActionResult Index()
        {
            return View();
        }

        // Action: NpnCustomerDetail
        public ActionResult NpnCustomerDetail() 
        {
            //Tạo đối tượng dữ liệu
            var customer = new NpnCustomer()
            {
                CustomerID = 1,
                FirstName = "Nguyễn Phú",
                LastName = "Nam",
                Address = "K22CNT3",
                YearOfBirth = 2004
            };
            ViewBag.customer = customer;
            return View();
        }

        //Get: NpnListCustomer
        public ActionResult NpnListCustomer()
        {
            var list = new List<NpnCustomer>()
            {
                new NpnCustomer()
             {                    
                CustomerID = 1,
                FirstName = "Nguyễn Phú",
                LastName = "Nam",
                Address = "K22CNT3",
                YearOfBirth = 2004           
        },
               new NpnCustomer() 
                {
                CustomerID = 2,
                FirstName = "Hoàng Quốc",
                LastName = "Minh",
                Address = "K22CNT3",
                YearOfBirth = 2004
                },
               new NpnCustomer()
                {
                CustomerID = 3,
                FirstName = "Đào Đoàn Xuân",
                LastName = "Duy",
                Address = "K22CNT3",
                YearOfBirth = 2004
                },
               new NpnCustomer()
                {
                CustomerID = 4,
                FirstName = "Phạm Gia Phúc",
                LastName = "Bảo",
                Address = "K22CNT3",
                YearOfBirth = 2004
                }
            };
            //ViewBag.list = list; //Đưa dữ liệu ra view bằng đối tượng ViewBag

            return View(list); 
        }
    }
}