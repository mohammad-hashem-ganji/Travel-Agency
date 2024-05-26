using Microsoft.AspNetCore.Mvc;

namespace TravelAgency.Controllers
{
    public class TicketController : Controller
    {
        public IActionResult Add()
        {
            return View();
        }
    }
}
