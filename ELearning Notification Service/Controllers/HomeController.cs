using ELearning_Notification_Service.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ELearning_Notification_Service.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //initial "Login-procedure"
            BrowserSession b = new BrowserSession();
            b.Get("http://elearning.eduapps.edu.vn/uel/login/index.php");
            b.FormElements["username"] = "ngant";
            b.FormElements["password"] = "0984567581";
            string response = b.Post("http://elearning.eduapps.edu.vn/uel/login/index.php");
            
            string view = b.Get("http://elearning.eduapps.edu.vn/uel/course/view.php?id=65");

            ViewBag.data = view;
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
    }
}