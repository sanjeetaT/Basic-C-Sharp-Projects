using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {

            // string text = "Hello";
            // System.IO.File.WriteAllText(@"C: \Users\Dridh\OneDrive\Documents\GitHub\Basic - C - Sharp - Projects\WebApplication3\WebApplication3\log\log.txt", text);

            //Random rnd = new Random(10);
            //var num = rnd.Next();
            //if(num > 20000)
            //{
            //    return View("About");
            //}

            //List<string> names = new List<string>
            //{
            //    "Jesse",
            //    "Adam",
            //    "Brett"
            //};
            //return View();

            User user = new User();
            user.Id = 1;
            user.FirstName = "Jesse";
            user.LastName = "Johnson";
            user.Age = 32;

            return View(user);
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            

            return View();
        }

        public ActionResult Contact(int id = 0)
        {
            ViewBag.Message = id;

            return View();
        }
    }
}