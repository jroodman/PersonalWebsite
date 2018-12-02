using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers {

    public class TennisController : Controller {
        [ResponseCache(Duration = 3600)]
        public IActionResult Index() {
            return View();
        }
    }
}
