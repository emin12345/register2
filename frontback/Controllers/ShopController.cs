using Microsoft.AspNetCore.Mvc;

namespace frontback.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
