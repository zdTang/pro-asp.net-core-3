﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Filters;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace WebApp.Filters
{
    
    [AttributeUsage(AttributeTargets.Method|AttributeTargets.Class, AllowMultiple = true)]
    public class GuidResponseTwoAttribute : Attribute, IAsyncAlwaysRunResultFilter,IFilterFactory
    {
        private int counter = 0;
        private string guid = Guid.NewGuid().ToString();
        // this belongs to IFilterFactory
        // if this value is "true" the filter will be reusable !
        public bool IsReusable => true;
        // this belongs to IFilterFactory
        public IFilterMetadata CreateInstance(IServiceProvider serviceProvider)
        {
            // can also use "NEW" keyword to instantiate a new instance
            // But who has register this Service into the collection
            return ActivatorUtilities.GetServiceOrCreateInstance<GuidResponseTwoAttribute>(serviceProvider);
        }

        public async Task OnResultExecutionAsync(ResultExecutingContext context, ResultExecutionDelegate next)
        {
            Dictionary<string, string> resultData;
            
            if(context.Result is ViewResult vr && vr.ViewData.Model is Dictionary<string, string> data)
            {
                resultData = data;
            }
            else
            {
                resultData = new Dictionary<string, string>();
                context.Result = new ViewResult() { 
                    ViewName ="/Views/Shared/Message.cshtml",
                    ViewData=new ViewDataDictionary(new EmptyModelMetadataProvider(),new ModelStateDictionary())
                    {Model=resultData}
                };
            }
            while (resultData.ContainsKey($"Counter_{counter}"))
            {
                counter++;
            }
            resultData[$"Counter_{counter}"] = guid;
            await next();
        }
    }
}
