using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;
using System.Collections.Generic;

namespace WebApp.Filters
{
    /// <summary>
    /// From the Interface :// Summary:
    //     A filter that surrounds execution of model binding, the action (and filters)
    //     and the action result (and filters).
    /// </summary>
    public class SimpleCacheAttribute : Attribute, IResourceFilter
    {
        
        private Dictionary<PathString, IActionResult> CachedResponses =new Dictionary<PathString, IActionResult>();

        public void OnResourceExecuting(ResourceExecutingContext context)
        {
            PathString path=context.HttpContext.Request.Path;
            if (CachedResponses.ContainsKey(path))
            {
                context.Result = CachedResponses[path];
                CachedResponses.Remove(path); // Why remove it ? 
            }
        }

        public void OnResourceExecuted(ResourceExecutedContext context)
        {
            // Cache the result: context.Result
            CachedResponses.Add(context.HttpContext.Request.Path, context.Result);
        }
    }

}
