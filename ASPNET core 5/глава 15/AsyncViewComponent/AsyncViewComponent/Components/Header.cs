using Microsoft.AspNetCore.Html;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ViewComponents;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncViewComponent.Components
{
    public class Header : ViewComponent
    {
        public async Task<IViewComponentResult> InvokeAsync()
        {
            string htmlContent = string.Empty;
            using (StreamReader reader = new StreamReader("File/Windows 10 Enterprise LTSC 2019 x64 MoverSoft 06.2019.iso") )
            {
                htmlContent = await reader.ReadToEndAsync();
            }
            return new HtmlContentViewComponentResult(new HtmlString(htmlContent)); 
        }
    }



    public class TimerViewComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            string htmlContent = DateTime.Now.ToString("HH:mm:ss");
            return View("default", htmlContent);
        }
    }
}
