#pragma checksum "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d53d3a90d27f91ef3497310b5ba606bf053a6c37"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\_ViewImports.cshtml"
using WebApp.Components;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d53d3a90d27f91ef3497310b5ba606bf053a6c37", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f489efd395508edd1380bb4edea42066f43f6345", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("bg-color", "info", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("text-color", "red", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebApp.TagHelpers.TrTagHelper __WebApp_TagHelpers_TrTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Home\Index.cshtml"
    
    Layout = "_SimpleLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>THIS IS TABLE</h1>\r\n<table class=\"table table-striped table-bordered table-sm\">\r\n    <thead>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53d3a90d27f91ef3497310b5ba606bf053a6c374180", async() => {
                WriteLiteral("\r\n            <th colspan=\"2\">Product Summary</th>\r\n        ");
            }
            );
            __WebApp_TagHelpers_TrTagHelper = CreateTagHelper<global::WebApp.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_TagHelpers_TrTagHelper);
            __WebApp_TagHelpers_TrTagHelper.BgColor = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __WebApp_TagHelpers_TrTagHelper.TextColor = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </thead>\r\n    \r\n    <tbody>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53d3a90d27f91ef3497310b5ba606bf053a6c375539", async() => {
                WriteLiteral("<th>Name</th><td>");
#nullable restore
#line 15 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Home\Index.cshtml"
                        Write(Model.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>");
            }
            );
            __WebApp_TagHelpers_TrTagHelper = CreateTagHelper<global::WebApp.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_TagHelpers_TrTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53d3a90d27f91ef3497310b5ba606bf053a6c376753", async() => {
                WriteLiteral("\r\n            <th>Price</th>\r\n            <td>");
#nullable restore
#line 18 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Home\Index.cshtml"
           Write(Model.Price.ToString("c"));

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n        ");
            }
            );
            __WebApp_TagHelpers_TrTagHelper = CreateTagHelper<global::WebApp.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_TagHelpers_TrTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d53d3a90d27f91ef3497310b5ba606bf053a6c378014", async() => {
                WriteLiteral("<th>Category ID</th><td>");
#nullable restore
#line 20 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Home\Index.cshtml"
                               Write(Model.CategoryId);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>");
            }
            );
            __WebApp_TagHelpers_TrTagHelper = CreateTagHelper<global::WebApp.TagHelpers.TrTagHelper>();
            __tagHelperExecutionContext.Add(__WebApp_TagHelpers_TrTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Product> Html { get; private set; }
    }
}
#pragma warning restore 1591
