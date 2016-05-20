using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.Controllers
{
    public class HelloWorld : Controller
    {
        public ActionResult Index()
        {
            return View ();
        }
    }
}
