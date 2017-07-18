using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace EruoOffice.Web.Controllers
{
    public class EurOfficeController : Controller
    {
        // GET: EurOffice
        public ActionResult Index()
        {
			//ViewBag.CatUrl = "http://thecatapi.com/api/categories/list";
			ViewBag.CatUrl = "/api/EuroOffApi/GetCatXml";
			ViewBag.CatImagesUrl = "/api/EuroOffApi/GetImagesXml";
			return View();
        }
    }
}