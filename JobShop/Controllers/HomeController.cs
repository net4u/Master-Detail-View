using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using JobShop.Models;

namespace JobShop.Controllers
{
    public class HomeController : Controller
    {
        private JobShopEntities db = new JobShopEntities();

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult _JobDetails()
        {
            var jobDetails = new Jobs()
            {
                //User = "",
                //Titlu = "",
                //Description = Jobs,
                //Content = Content
            };
            return PartialView(jobDetails);
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
    }
}