#pragma checksum "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c88e5936ff7241113f9b1e39ce00fb0ff52691bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(WebApp.Pages.Pages_Message), @"mvc.1.0.razor-page", @"/Pages/Message.cshtml")]
namespace WebApp.Pages
{
    #line hidden
    using System;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line 2 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\_ViewImports.cshtml"
using WebApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
using Microsoft.AspNetCore.Mvc.Filters;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
using System.Collections.Generic;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
using WebApp.Filters;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "/pages/message")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c88e5936ff7241113f9b1e39ce00fb0ff52691bc", @"/Pages/Message.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ab2ced71c86b8f79b5664eda1189debce82d4ea8", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Message : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("table table-sm table-striped table-bordered"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::WebApp.TagHelpers.TableFooterSelector __WebApp_TagHelpers_TableFooterSelector;
        private global::WebApp.TagHelpers.CellTagHelper __WebApp_TagHelpers_CellTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
 if (Model.Message is string) {
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
Write(Model.Message);

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
                  
} else if (Model.Message is IDictionary<string, string>) {
    var dict = Model.Message as IDictionary<string, string>;

#line default
#line hidden
#nullable disable
            WriteLiteral("    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("table", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88e5936ff7241113f9b1e39ce00fb0ff52691bc5435", async() => {
                WriteLiteral("\r\n        <thead><tr>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88e5936ff7241113f9b1e39ce00fb0ff52691bc5713", async() => {
                    WriteLiteral("Name");
                }
                );
                __WebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::WebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__WebApp_TagHelpers_CellTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("th", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88e5936ff7241113f9b1e39ce00fb0ff52691bc6622", async() => {
                    WriteLiteral("Value");
                }
                );
                __WebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::WebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__WebApp_TagHelpers_CellTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</tr></thead>\r\n        <tbody>\r\n");
#nullable restore
#line 15 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
             foreach (var kvp in dict) {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88e5936ff7241113f9b1e39ce00fb0ff52691bc7920", async() => {
#nullable restore
#line 16 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
                   Write(kvp.Key);

#line default
#line hidden
#nullable disable
                }
                );
                __WebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::WebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__WebApp_TagHelpers_CellTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("td", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c88e5936ff7241113f9b1e39ce00fb0ff52691bc9042", async() => {
#nullable restore
#line 16 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
                                    Write(kvp.Value);

#line default
#line hidden
#nullable disable
                }
                );
                __WebApp_TagHelpers_CellTagHelper = CreateTagHelper<global::WebApp.TagHelpers.CellTagHelper>();
                __tagHelperExecutionContext.Add(__WebApp_TagHelpers_CellTagHelper);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</tr>\r\n");
#nullable restore
#line 17 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    ");
            }
            );
            __WebApp_TagHelpers_TableFooterSelector = CreateTagHelper<global::WebApp.TagHelpers.TableFooterSelector>();
            __tagHelperExecutionContext.Add(__WebApp_TagHelpers_TableFooterSelector);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 20 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
        }
        #pragma warning restore 1998
#nullable restore
#line 22 "D:\LeetCode\LearnASP\Pro-Asp-net-core-3\Update for ASP.NET Core 5 and .NET 5.0\Chapter 30\Beginning of Chapter\WebApp\Pages\Message.cshtml"
            
    [RequireHttps]
    //[SimpleCache]
    //[SimpleCacheAsync]
    //[ChangePageArgs]
    //[ResultDiagnostics]
    [ResultDiagnosticsTwo]
    public class MessageModel : PageModel {

        public object Message { get; set; } = $"{DateTime.Now.ToLongTimeString()}:This is the Message Razor Page";
        public void OnGet(string message1, string message2)
        {
            Message = $"{message1},{message2}";
        }

        // Override Page Filter method directly!
        public override void OnPageHandlerExecuting(PageHandlerExecutingContext context)
        {
            if (context.HandlerArguments.ContainsKey("message1"))
            {
                context.HandlerArguments["message1"] = "New message--Mike Tang";
            }
        }
    }

#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MessageModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MessageModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<MessageModel>)PageContext?.ViewData;
        public MessageModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
