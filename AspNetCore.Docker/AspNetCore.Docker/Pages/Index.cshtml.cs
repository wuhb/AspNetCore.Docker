using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore.Docker.Pages
{
    public class IndexModel : PageModel
    {
        public string Msg { get; set; }

        public void OnGet()
        {
            Msg = Environment.GetEnvironmentVariable("X-Path", EnvironmentVariableTarget.Machine);//"abc";
            if (string.IsNullOrEmpty(Msg))
                Msg = "default";
        }
    }
}
