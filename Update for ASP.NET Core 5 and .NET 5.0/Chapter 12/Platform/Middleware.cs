﻿using Microsoft.AspNetCore.Http;
using System.Threading.Tasks;
using Microsoft.Extensions.Options;

namespace Platform {

    public class QueryStringMiddleWare {
        private RequestDelegate next;
        
        //why we need a parameterless constructor here ?
        public QueryStringMiddleWare() {
            // do nothing
        }
        
        //Who will instantiate this middleware
        public QueryStringMiddleWare(RequestDelegate nextDelegate) {
            next = nextDelegate;
        }

        public async Task Invoke(HttpContext context) {
            if (context.Request.Method == HttpMethods.Get
                        && context.Request.Query["custom"] == "true") {
                await context.Response.WriteAsync("Class-based Middleware \n");
            }
            // Class-based middleware can be used as normal or Terminal Middleware 
            // As it can deal with the "next" either it has value or not
            if (next != null) { // next can be Null if use parameterless Constructor
                await next(context);
            }
        }
    }

    public class LocationMiddleware {
        private RequestDelegate next;
        private MessageOptions options;
        // pass Option to the constructor
        public LocationMiddleware(RequestDelegate nextDelegate,
                IOptions<MessageOptions> opts) {
            next = nextDelegate;
            options = opts.Value;
        }

        public async Task Invoke(HttpContext context) {
            if (context.Request.Path == "/location") {
                await context.Response
                    .WriteAsync($"the new location is : {options.CityName}, {options.CountryName}");
            } else {
                await next(context);
            }
        }
    }
}
