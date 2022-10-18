using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class DataExchange : Controller
    {
        [Route("/dataex")]
        public IActionResult Index()
        {
            HttpContext.Session.SetString("Username", "mayur@KPMG.COM");
            return View("Index");
        }
        [Route("/next")]
        public IActionResult NextPage()
        {
            HttpContext.Session.GetString("Username");
            return View();
        }
    }
}
