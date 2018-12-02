using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers {

    public class ErrorController : Controller {
        [ResponseCache(Duration = 3600)]
        [HttpGet("/Error/{statusCode}")]
        public IActionResult Index(int statusCode) {
            ViewData["ErrorCode"] = statusCode;
            return View();
        }
    }
}
