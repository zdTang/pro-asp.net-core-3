﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.AspNetCore.Mvc.Routing;
using Microsoft.AspNetCore.Mvc.ViewFeatures;
using Microsoft.AspNetCore.Razor.TagHelpers;
using SportsStore.Models.ViewModels;

namespace SportsStore.Infrastructure
{
    [HtmlTargetElement("div",Attributes = "page-model")]
    public class PageLinkTagHelper:TagHelper
    {
        private IUrlHelperFactory urlHelperFactory;
/// <summary>
/// Who will pass the helperFactory here ???
/// The framework has register several hunderds of services
/// </summary>
/// <param name="helperFactory"></param>
        public PageLinkTagHelper(IUrlHelperFactory helperFactory)
        {
            urlHelperFactory = helperFactory;
        }
        
        [ViewContext]
        [HtmlAttributeNotBound]
        public ViewContext ViewContext { set; get; }
        public PagingInfo PageModel { get; set; } // this will be a attribute of <div>
        public string PageAction { get; set; }    // this will be a attribute of <div>
/// <summary>
/// Here is the key !! here be dragons
/// </summary>
/// <param name="context"></param>
/// <param name="output"></param>
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //base.Process(context, output);
            IUrlHelper urlHelper = urlHelperFactory.GetUrlHelper(ViewContext);
            TagBuilder result = new TagBuilder("div");
            // PageModel tell how many pages it is 
            for (int i = 1; i <= PageModel.TotalPages; i++)
            {
                TagBuilder tag = new TagBuilder("a");
                //PageAction will work with Action to create a URL to Action
                tag.Attributes["href"] = urlHelper.Action(PageAction, new { productPage = i });
                tag.InnerHtml.Append(i.ToString());
                result.InnerHtml.AppendHtml(tag);
            }

            output.Content.AppendHtml(result.InnerHtml);
        }
    }
}