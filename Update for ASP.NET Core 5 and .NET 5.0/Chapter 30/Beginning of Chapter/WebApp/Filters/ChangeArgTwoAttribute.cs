using Microsoft.AspNetCore.Mvc.Filters;
using System.Threading.Tasks;

namespace WebApp.Filters
{
    public class ChangeArgTwoAttribute:ActionFilterAttribute
    {
       // Override the virtual Method of the "ActionFilterAttribute" class
        public override async Task OnActionExecutionAsync(ActionExecutingContext context,ActionExecutionDelegate next)
        {
            if (context.ActionArguments.ContainsKey("message1"))
            {
                context.ActionArguments["message1"] = "New message";
            }
            await next();
        }
    }
}
