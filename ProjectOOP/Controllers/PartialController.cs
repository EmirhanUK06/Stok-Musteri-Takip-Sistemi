using Microsoft.AspNetCore.Mvc;

namespace ProjectOOP.Controllers
{
    public class PartialController : Controller
    {
        public IActionResult Index()
        {
            ViewBag.A = "Testtir.";
            return RedirectToAction("Shared", "_UILayout");
        }
    }
}
