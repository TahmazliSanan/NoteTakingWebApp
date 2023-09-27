using Microsoft.AspNetCore.Mvc;

namespace NoteTakingWebApp.UI.Controllers
{
    public class HomeController : Controller
    {
        [HttpGet]
        public IActionResult Home()
        {
            return View();
        }
    }
}