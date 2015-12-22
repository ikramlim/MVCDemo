using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVCDemo.Models;

namespace MVCDemo.Controllers
{
    public class DemoController : Controller
    {
        // GET: Demo
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult HelloAjax()
        {
            return Content("Hello ikramlim", "text/plain");
        }
        public ActionResult Sum(int a, int b)
        {
            return Content((a + b).ToString(), "text/plain");
        }

        public ActionResult DisplayObject()
        {
            Product p1 = new Product("pr1", "Name 1", 1000);
            return Json(p1, JsonRequestBehavior.AllowGet);
        }

        public ActionResult DisplayListObject()
        {
            List<Product> listProduct = new List<Product>();
            listProduct.Add(new Product("pr1", "Name 1", 1000));
            listProduct.Add(new Product("pr2", "Name 2", 2000));
            listProduct.Add(new Product("pr3", "Name 3", 3000));
            return Json(listProduct, JsonRequestBehavior.AllowGet);
        }
    }
}