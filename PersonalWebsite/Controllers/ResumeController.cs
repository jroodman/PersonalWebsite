using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers {

    public class ResumeController : Controller {
        [ResponseCache(Duration = 3600)]
        public IActionResult Index() {
            return View();
        }
    }
}
