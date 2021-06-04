using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HomeController.Models;

namespace HomeController.Controllers
{
    public class ProductsController : Controller
    {
        // GET: Products
        public ActionResult Index()
        {
            if (Session["UserName"] == null)
            {
                return RedirectToAction("login", "home");
            }
            else
            {
                NorthwindOriginalEntities1 db = new NorthwindOriginalEntities1();
                List<Products> model = db.Products.ToList();
                db.Dispose();

                return View(model);
            }
        }

        public ActionResult TuoteKuva()
        {
            NorthwindOriginalEntities1 db = new NorthwindOriginalEntities1();
            List<Products> model = db.Products.ToList();
            db.Dispose();

            return View(model);
        }
    }
}