using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace KnockOutDemo.Controllers
{
    public class HomeController : Controller
    {
        //
        // GET: /HomeController/

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Customers()
        {  
            return View();  
        }

    }
}
