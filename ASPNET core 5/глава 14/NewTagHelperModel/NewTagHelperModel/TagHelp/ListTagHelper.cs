using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Razor.TagHelpers;
using NewTagHelperModel.Models;

namespace NewTagHelperModel.TagHelp
{
    public class ListTahTagHelper : TagHelper
    {
        public User User { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var content = $@"<p>Имя: <b>{User.Name}</b></p><p>Возраст: <b>{User.Age}</b></p>";
            output.Content.SetHtmlContent(content);
        }
    }
    public class UserInfoTagHelper : TagHelper
    {
        public User User { get; set; }
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            output.TagName = "div";
            var content = $@"<p>Имя: <b>{User.Name}</b></p><p>Возраст: <b>{User.Age}</b></p>";
            output.Content.SetHtmlContent(content);
        }
    }
}
