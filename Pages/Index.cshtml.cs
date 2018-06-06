using Microsoft.AspNetCore.Mvc.RazorPages;
using System;

namespace FirstCore.Pages
{
    public class Index : PageModel
    {
        public string Message { get; private set; } = "测试Razor";

        public void OnGet()
        {
            Message += $"Server Time is {DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss")}";
        }
    }
}