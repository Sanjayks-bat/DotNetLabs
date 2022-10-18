using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class SimpleController : Controller
    {
        [Route("/simple")]
        public IActionResult Index()
        {
            return View("Home Page");
        }

        [Route("/names")]
        public IActionResult DisplayNames()
        {
            return View("NamesView");
        }

        [Route("/onlogin")]
        public IActionResult OnLogin(string username,string password)
        {
            if (username == "admin" && password == "nimda")
            {
                ViewBag.status = "Login Successfull";
                return View("Index");
            }
            else
            {
                ViewBag.status = "Login Failed";
                return View("Index");
            }
        }

    }
}
