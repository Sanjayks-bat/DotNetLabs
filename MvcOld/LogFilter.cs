using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.Remoting.Contexts;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;

namespace MvcOld
{
    public class LogFilter:ActionFilterAttribute
    {
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            Log("In on Action Executing", filterContext.RouteData);
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            Log("In on Action Executed", filterContext.RouteData);
        }
       
        public override void OnResultExecuting(ResultExecutingContext filterContext)
        {
            Log("In on Result Executing", filterContext.RouteData);
        }

        public override void OnResultExecuted(ResultExecutedContext filterContext)
        {
            Log("In on Result Executed",filterContext.RouteData);
        }

        public void Log(string msg,RouteData context)
        {
            Debug.WriteLine(msg);
            Debug.WriteLine("Details: {0}, ControllerName: {1}, ActionName:{2}", msg, context.Values["controller"], context.Values["action"]);
        }
    }
}