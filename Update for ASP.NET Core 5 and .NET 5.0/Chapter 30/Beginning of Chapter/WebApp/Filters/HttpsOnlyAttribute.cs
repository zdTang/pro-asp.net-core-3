using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using System;

namespace WebApp.Filters
{
    /// <summary>
    /// Create [HttpsOnly] Authorization Filter
    /// Be Aware of the Interface we are supposed to inherit.
    /// </summary>
    public class HttpsOnlyAttribute : Attribute, IAuthorizationFilter
    {
        public void OnAuthorization(AuthorizationFilterContext context)
        {
            // The "context" object almost provide everythis we required
            if (!context.HttpContext.Request.IsHttps)
            {
                // Here only for demo.
                // In production, would redirect to a meaningful webpage other than 403
                context.Result = new StatusCodeResult(StatusCodes.Status403Forbidden);
            }
        }
    }
}
