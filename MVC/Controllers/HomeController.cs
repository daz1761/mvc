using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVC.Controllers
{
    public class HomeController : Controller
    {
        // a view inherits from ActionResult (ViewResult)
        public ActionResult Index(string id, string name)
        {
                                                    // Webforms method
            // return "Id = " + id + " Name = " + Request.QueryString["name"];
            // return "Id = " + id + " Name = " + name;

            // This is the URL string we pass: http://mvc.local/Home/index/10?name=darryl

            //ViewBag.Countries = new List<string>()
            ViewData["Countries"] = new List<string>()
            {
                "India",
                "US",
                "UK",
                "Canada"
            }; // ViewBag is dynamic

            return View();
        }

        public string getDetails()
        {
            return "Get details from the controller";
        }
    }
}