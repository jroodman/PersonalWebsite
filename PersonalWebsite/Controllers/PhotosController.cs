using Microsoft.AspNetCore.Mvc;

namespace PersonalWebsite.Controllers {

    public class PhotosController : Controller {
        [ResponseCache(Duration = 3600)]
        public IActionResult Index() {
            return View();
        }
    }
}