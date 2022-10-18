using Microsoft.AspNetCore.Mvc;

namespace FirstMVC.Controllers
{
    public class SimpleLabController : Controller
    {
        [Route("/lab")]
        public IActionResult Index()
        {
            return View();
        }

        [Route("/getname")]
        public IActionResult getName()
        {
            
            ViewBag.Name = "Anil";
            return View("Index");
        }
        [Route("/getplace")]
        public IActionResult getPlace()
        {
            ViewBag.Place = "Amritsar";
            return View("Index");
        }
        [Route("/getanimal")]
        public IActionResult getAnimal()
        {
            ViewBag.Animal = "Anaconda";
            return View("Index");
        }
        [Route("/getthing")]
        public IActionResult getThing()
        {
            ViewBag.Thing = "Adobe";
            return View("Index");
        }
    }
}
