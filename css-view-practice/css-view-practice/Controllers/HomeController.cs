using Microsoft.AspNetCore.Mvc;

namespace css_view_practice.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Start() => View();
        public IActionResult Test() => View();
        public IActionResult SummerSale() => View();
        public IActionResult WinterSale() => View();
        public IActionResult Bootstrap() => View();

    }
}
