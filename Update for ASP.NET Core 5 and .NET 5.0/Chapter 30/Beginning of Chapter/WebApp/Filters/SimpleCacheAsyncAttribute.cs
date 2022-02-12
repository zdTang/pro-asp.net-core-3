using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Filters
{
    public class SimpleCacheAsyncAttribute : Attribute, IAsyncResourceFilter
    {

        private Dictionary<PathString, IActionResult> CachedResponses = new Dictionary<PathString, IActionResult>();
        
        public async Task OnResourceExecutionAsync(ResourceExecutingContext context, ResourceExecutionDelegate next)
        {
            PathString path=context.HttpContext.Request.Path;
            if (CachedResponses.ContainsKey(path))
            {
                context.Result = CachedResponses[path];
                CachedResponses.Remove(path);
            }
            else
            {
                // Get "execContext" after executing "next"
                ResourceExecutedContext execContext=await next();
                CachedResponses.Add(path, execContext.Result);
            }
        }
    }

}
