using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using PersonalWebsite.Models;
using PersonalWebsite.Services;

namespace PersonalWebsite.Controllers {

    public class ContactController : Controller {
        private readonly static string _toName = "Jason Roodman";
        private readonly static string _toAddress = "jason.j.roodman@gmail.com";
        private readonly static string _subject = "Message From JasonRoodman.com";

        [HttpGet]
        public IActionResult Index() {
            ViewData["Sent"] = false;
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Index(EmailFormModel emailFormModel) {
            if (ModelState.IsValid) {
                await EmailService.SendEmail(
                    toName: _toName,
                    toAddress: _toAddress,
                    subject: _subject,
                    htmlBody: emailFormModel.GetFormattedEmailBody());

                ViewData["Sent"] = true;
                return View(emailFormModel);
            }
            ViewData["Sent"] = false;
            return View(emailFormModel);
        }
    }
}
