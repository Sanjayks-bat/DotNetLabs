using ForAuth.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace ForAuth.Controllers
{
    public class HomeController : Controller
    {
        [HttpPost]
        public ActionResult LogOut()
        {
            FormsAuthentication.SignOut();
            return RedirectToAction("Index");
        }
        [HttpGet]
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]

        public ActionResult Index(User pUser)
        {
            //get all users and search user as per username and password
            var userDb = ForAuth.Models.User.GetUsers();
            User found = userDb.Where(u => u.Username == pUser.Username && u.Password == pUser.Password).ToList().FirstOrDefault();
            if(found != null)
            {
                FormsAuthentication.SetAuthCookie(found.Username, false);
                return RedirectToAction("Contact");
            }
            return View("Index");

        }
        [Authorize(Roles= "Admin,Customer")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        [Authorize(Roles ="Customer")]
        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}