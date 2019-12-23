using ruanj1801.Filters;
using ruanj1801.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ruanj1801.Controllers
{
    [RequireAuthentication]
    [ActionResultExceptionFilter]
    public class HomeController : Controller
    {
        private CourseManagerEntities db = new CourseManagerEntities();
        public ActionResult Index()
        {
            /*var siteInfo = new WebsiteInfo("", "");
            ViewBag.SiteInfo = siteInfo;
            ViewData["SiteInfo"]= siteInfo;
            if(new Random().Next(2)==0)
            return View("~/Views/Home/View.cshtml");
            else
            return View(siteInfo);
            */
            //return View("~/Views/Shared/Navbar.cshtml");
            
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [ChildActionOnly]
        public ActionResult Navbar()
        {
            var site = new WebsiteInfo("");
            ViewBag.Site = site;
            site.ActionLinks = db.ActionLinks.ToList();
            return PartialView("~/Views/Shared/Navbar.cshtml");
        }
        public ActionResult SideBar()
        {
            var sidebars = db.SideBars.ToList();
            ViewBag.SideBars = sidebars;
            return PartialView("~/Views/Shared/SideBar.cshtml");
        }
    }
}