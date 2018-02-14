using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Lab1.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            return View();
        }
        //Get:Product/Details
        public ActionResult Details(string product)
        {
            //check  empty Product
            if (product == null)
            {
                return View("Error");
            }
            ViewBag.Product = product;
            return View();  
        }
    }
}