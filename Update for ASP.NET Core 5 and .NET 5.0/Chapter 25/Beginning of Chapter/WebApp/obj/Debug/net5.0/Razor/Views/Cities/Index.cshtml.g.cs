#pragma checksum "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa5fa1550b019d361d139376be64b2e33bf67391"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cities_Index), @"mvc.1.0.view", @"/Views/Cities/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa5fa1550b019d361d139376be64b2e33bf67391", @"/Views/Cities/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f489efd395508edd1380bb4edea42066f43f6345", @"/Views/_ViewImports.cshtml")]
    public class Views_Cities_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<City>>
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
        private global::WebApp.TagHelpers.TrTagHelper __WebApp_TagHelpers_TrTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml"
    
    Layout = "_ImportantLayout";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"m-2\">\r\n    <table class=\"table table-sm table-striped table-bordered\">\r\n        <tbody>\r\n");
#nullable restore
#line 9 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml"
             foreach (City c in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("tr", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "aa5fa1550b019d361d139376be64b2e33bf673913920", async() => {
                WriteLiteral("\r\n                    <td>");
#nullable restore
#line 11 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml"
                   Write(c.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 12 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml"
                   Write(c.Country);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 13 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml"
                   Write(c.Population);

#line default
#line hidden
#nullable disable
                WriteLiteral("</td>\r\n                ");
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
            WriteLiteral("\r\n");
#nullable restore
#line 15 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 25\Beginning of Chapter\WebApp\Views\Cities\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<City>> Html { get; private set; }
    }
}
#pragma warning restore 1591
