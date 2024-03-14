using frontback.Contexts;

using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace frontback.Controllers
{
    public class HomeController : Controller
    {
        private readonly PronioDbContext _context;

        public HomeController(PronioDbContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index()
        {


            var sliders = await _context.Sliders.ToListAsync();
            var shipping = await _context.Shippings.ToListAsync();

            HomeViewModel homeViewModel = new HomeViewModel
            {

                Sliders = sliders,
                Shippings = shipping

            };

            return View(homeViewModel);
        }
    }
}
