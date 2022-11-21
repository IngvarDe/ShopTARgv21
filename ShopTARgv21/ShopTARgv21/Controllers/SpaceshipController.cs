using Microsoft.AspNetCore.Mvc;

namespace ShopTARgv21.Controllers
{
    public class SpaceshipController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
