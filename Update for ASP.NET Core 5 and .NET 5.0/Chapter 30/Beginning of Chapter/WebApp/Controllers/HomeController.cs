using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApp.Filters;

namespace WebApp.Controllers {
    [HttpsOnly]
    public class HomeController : Controller {
       
        public IActionResult Index() {
            return View("Message","This is the Index action on the Home controller");
        }

        //[ChangeArg]
        [ChangeArgTwo]
        public IActionResult Messages(string message1, string message2 = "none")
        {
            return View("Message",$"{message1},{message2}");
        }
    }
}
