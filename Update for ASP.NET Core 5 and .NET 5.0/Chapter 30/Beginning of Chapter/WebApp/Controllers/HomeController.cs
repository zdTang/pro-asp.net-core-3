using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using WebApp.Filters;

namespace WebApp.Controllers {
    [HttpsOnly]
    public class HomeController : Controller {
       
        public IActionResult Index() {
            return View("Message","This is the Index action on the Home controller");
        }

        //[ChangeArg]
        //[ChangeArgTwo]
        public IActionResult Messages(string message1, string message2 = "none")
        {
            return View("Message",$"{message1},{message2}");
        }

        // called before Action is invoked
        public override void OnActionExecuting(ActionExecutingContext context)
        {
            if (context.ActionArguments.ContainsKey("message1"))
            {
                context.ActionArguments["message1"] = "New message";
            }
           
        }
        // called after Action is invoked
        public override void OnActionExecuted(ActionExecutedContext context)
        {
            context.Result = View("Message", "MIKE,TANG");
        }

    }
}
