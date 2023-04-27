using Microsoft.AspNetCore.Mvc;

namespace ProjectOOP.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
