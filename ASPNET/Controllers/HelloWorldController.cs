using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ASPNET.Controllers
{
    public class HelloWorldController : Controller
    {
	// Get: /HelloWorld/
        public string Index()
        {
            return "This is my default action";
        }

	// Get: /HelloWorld/Welcome/
        public string Welcome()
        {
            return "Welcome action"; 
        }
    }
}
