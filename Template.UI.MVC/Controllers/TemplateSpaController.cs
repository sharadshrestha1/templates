using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Template.UI.MVC.Controllers
{
    public class TemplateSpaController : Controller
    {
        // GET: TemplateSpa
        public ActionResult Index()
        {
            return View();
        }
    }
}