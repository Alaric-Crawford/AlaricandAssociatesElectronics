using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AlaricandAssociatesElectronicsWholesale.Controllers
{
    public class HomeController : Controller
    {
        Models.AlaricWholesaleEntities1 db = new Models.AlaricWholesaleEntities1();
        //
        // GET: /Home/

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Navigation()
        {
            var categories = db.Categories.Where(x => x.ParentID == null);
            return PartialView(categories);
        }

        public ActionResult Breadcrumbs(int id)
        {
            var category = db.Categories.Find(id);
            var breadcrumbList = new List<Models.Category>();
            while (category.ParentID != null)
            {
                breadcrumbList.Add(category);
                category = category.ParentCategory;
            }
            breadcrumbList.Add(category);
            breadcrumbList.Reverse();
            return PartialView(breadcrumbList);
        }
    }
}
