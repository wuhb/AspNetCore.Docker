using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace AspNetCore.Docker.Controllers
{
    public class HomeController: Controller
    {
        public ActionResult Index()
        {
            ViewBag.msg = "abc";// Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            //ViewBag.Content = Environment.GetEnvironmentVariable("Path", EnvironmentVariableTarget.Machine);
            return View();
        }
    }
}
