using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Encodings.Web;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcProjectStarter.Controllers
{
    public class HelloWorldController : Controller
    {
        public int TotalRequestCount { get; set; } = 0;
        // GET: /<controller>/
        public IActionResult Index()
        {
            TotalRequestCount++;
            return View();
        }

        public IActionResult Welcome(string name)
        {
            TotalRequestCount++;

            ViewData["Message"] = "Hello " + name;
            ViewData["NumTimes"] = TotalRequestCount;

            return View();
        }
    }
}
