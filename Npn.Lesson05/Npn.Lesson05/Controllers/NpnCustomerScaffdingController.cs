using Npn.Lesson05.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace Npn.Lesson05.Controllers
{
    public class NpnCustomerScaffdingController : Controller
    {
        //mocdata
        private static List<NpnCustomer> listCustomer = new List<NpnCustomer>()
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
    // GET: NpnCustomerScaffding
    // listcustomer
    public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult NpnCreate()
        {
            var model = new NpnCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult NpnCreate(NpnCustomer model)
        {
            //thêm mới đối tượng kh ách hàng bào ds dữ liệu
             listCustomer.Add(model);
            //return View(model);
            //Chuyển về trang danh sách
            return RedirectToAction("Index");
        }

        public ActionResult NpnEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}