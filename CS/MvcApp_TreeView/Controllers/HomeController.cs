using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcApp_TreeView.Controllers {
    public class HomeController : Controller {
        public object CheckedValues { get; set; }

        public ActionResult Index() {
            ViewBag.Message = "Welcome to DevExpress Extensions for ASP.NET MVC!";
            return View(CheckedValues);
        }

        [HttpPost]
        public ActionResult PostTreeViewValues() {
            CheckedValues = Request.Params["hf"];

            ViewBag.Message = "The TreeView state has been restored successfully";
            return View("Index", CheckedValues);
        }
    }
}
