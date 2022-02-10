using Microsoft.AspNetCore.Razor.TagHelpers;

namespace WebApp.TagHelpers
{
    public class TrTagHelper:TagHelper
    {
        public string BgColor { get; set; } = "dark";
        public string TextColor { get; set; } = "white";

        /// <summary>
        /// This method id from TagHelper
        /// </summary>
        /// <param name="context"></param>
        /// <param name="output"></param>
        public override void Process(TagHelperContext context,TagHelperOutput output)
        {
            output.Attributes.SetAttribute("class", $"bg-{BgColor} text-center text-{TextColor}");
        }

    }
}
