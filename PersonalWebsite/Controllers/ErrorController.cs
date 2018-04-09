using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;


namespace PersonalWebsite.Controllers
{
    public class ErrorController : Controller
    {
        // GET: /Error/
        [HttpGet("/Error/{statusCode}")]
        public IActionResult Index(int statusCode)
        {
            ViewData["ErrorCode"] = statusCode;
            return View();
        }
    }
}
