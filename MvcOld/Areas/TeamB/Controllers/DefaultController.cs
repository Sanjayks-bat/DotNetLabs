using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MvcOld.Areas.TeamB.Controllers
{
    public class DefaultController : Controller
    {
        // GET: TeamB/Default
        public ActionResult Index()
        {
            return View();
        }
    }
}