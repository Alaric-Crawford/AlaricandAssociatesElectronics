using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlaricandAssociatesElectronicsWholesale.Controllers
{
    public class ShopController : Controller
    {
        Models.AlaricWholesaleEntities1 db = new Models.AlaricWholesaleEntities1();
        //
        // GET: /Shop/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ByCategory(int id)
        {
            var category = db.Categories.Find(id);
            category.AllProducts = db.GetProductsByCategoryID(id).ToList();
            return View(category);
        }
    }
}
