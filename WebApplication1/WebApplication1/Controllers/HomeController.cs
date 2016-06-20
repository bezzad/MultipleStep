using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication1.Core;

namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            var opt = new MultipleStepProgressTabOption()
            {
                Steps = new List<string>()
                {
                    "Step 1",
                    "Step 2",
                    "Step 3",
                    "Step 4",
                    "End Step"
                },
                CurrentStepIndex = 3            
            };
            return View(opt);
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