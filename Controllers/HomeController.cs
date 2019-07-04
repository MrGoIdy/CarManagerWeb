using CarManagerWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;

namespace CarManagerWeb.Controllers
{
    public class HomeController : Controller
    {
        [OutputCache(Duration = 15, Location = OutputCacheLocation.Any)]
        public ActionResult Index()
        {
            return View(CarManager.GetAllBrands());
        }


        [OutputCache(Duration = 15, Location = OutputCacheLocation.Any, VaryByParam = "brandId;")]
        public ActionResult Models(int brandId, string brandName)
        {
            ViewBag.Brand = brandName;
            return PartialView(CarManager.GetModels(brandId));
        }
    }
}