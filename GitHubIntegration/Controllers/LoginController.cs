using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace GitHubIntegration.Controllers
{
    public class LoginController : Controller
    {
        // GET: Login
        public ActionResult Index()
        {
             int result=50;
            return View();
        }

         public ActionResult Index2()
        {          
            return View();
        }

         public ActionResult Index1()
        {
            return View();
        }
    }
}
