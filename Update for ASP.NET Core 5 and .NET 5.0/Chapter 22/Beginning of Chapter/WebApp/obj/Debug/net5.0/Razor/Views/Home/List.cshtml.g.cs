#pragma checksum "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9aea8391c358c64a1e4c2464b0b0706ce8f26a75"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_List), @"mvc.1.0.view", @"/Views/Home/List.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 1 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9aea8391c358c64a1e4c2464b0b0706ce8f26a75", @"/Views/Home/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2176f5499582251db6d13138376202d02ac00fbf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
   
    decimal average = Model.Average(p => p.Price);
    // if the view has complate HTML element, set Layout as null to avoid duplication
    Layout = null;
    Func<Product, object> row = 

#line default
#line hidden
#nullable disable
            item => new global::Microsoft.AspNetCore.Mvc.Razor.HelperResult(async(__razor_template_writer) => {
                PushWriter(__razor_template_writer);
                WriteLiteral("<tr><td>");
#nullable restore
#line 6 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
                                    Write(item.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td><td>");
#nullable restore
#line 6 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
                                                       Write(item.Price);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td></tr>");
                PopWriter();
            }
            )
#nullable restore
#line 6 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
                                                                                 ;

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aea8391c358c64a1e4c2464b0b0706ce8f26a754842", async() => {
                WriteLiteral("\r\n    <link href=\"/lib/twitter-bootstrap/css/bootstrap.min.css\" rel=\"stylesheet\" />\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9aea8391c358c64a1e4c2464b0b0706ce8f26a755897", async() => {
                WriteLiteral(@"
    <h6 class=""bg-secondary text-white text-center m-2 p-2"">Products</h6>
    <div class=""m-2"">
        <table class=""table table-sm table-striped table-bordered"">
            <thead>
                <tr><th>Name</th><th>Price</th><th></th></tr>
            </thead>
            <tbody>
");
#nullable restore
#line 21 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
                 foreach (Product p in Model) {
                    

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
               Write(row(p));

#line default
#line hidden
#nullable disable
#nullable restore
#line 32 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 22\Beginning of Chapter\WebApp\Views\Home\List.cshtml"
                           
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591
