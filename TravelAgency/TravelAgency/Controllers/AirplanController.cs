using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Controllers
{
    public class AirplanController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
