using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Filters
{

    /// <summary>
    /// This approach inherit "ResultFilterAttribute" directly other than those Interfaces
    /// </summary>

    public class ResultDiagnosticsTwoAttribute:ResultFilterAttribute
    {
        public async override Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            
            if (context.HttpContext.Request.Query.ContainsKey("diag"))
            {
                Dictionary<string, string> diagData = new Dictionary<string, string> {
                    { "Result type", context.Result.GetType().Name }
                };

                if (context.Result is ViewResult vr)
                {
                    diagData["View Name"] = vr.ViewName;
                    diagData["Model Type"] = vr.ViewData.Model.GetType().Name;
                    diagData["Model Data"] = vr.ViewData.Model.ToString();
                }
                else if (context.Result is PageResult pr)
                {
                    diagData["Model Type"] = pr.Model.GetType().Name;
                    diagData["Model Data"] = pr.ViewData.Model.ToString();
                }
                // Create a ViewResult
                context.Result = new ViewResult()
                {
                    ViewName = "Views/Shared/Message.cshtml",
                    // Create View Data
                    ViewData = new ViewDataDictionary(new EmptyModelMetadataProvider(), new ModelStateDictionary()) { Model = diagData }
                };
            }
            await next();
        }
    }
}
