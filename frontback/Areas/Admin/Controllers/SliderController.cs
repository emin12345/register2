using frontback.Areas.Admin.ViewModels;
using frontback.Contexts;
using frontback.Models;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace frontback.Areas.Admin.Controllers;

[Area("Admin")]

public class SliderController : Controller
{

    private readonly PronioDbContext _context;
    private readonly IWebHostEnvironment _webHostEnvironment;
    private IWebHostEnvironment? webHostEnvironment;

    public SliderController(PronioDbContext context)
    {
        _context = context;
        _webHostEnvironment = webHostEnvironment;
    }
   



public async Task<IActionResult> Index()
    {
        var sliders = await _context.Sliders.ToListAsync();
        return View(sliders);
    }

    public IActionResult Create()
    {
        return View();
    }
    [HttpPost]
    public async Task<IActionResult> Create(SliderCreateViewModel Slider)
    {
        string filename = $"{Guid.NewGuid()}-{Slider.File.FileName}";
        string path = Path.Combine(_webHostEnvironment.WebRootPath, "assets", "images", "website-images", filename);


        using (FileStream stream = new FileStream(path, FileMode.Create))
        {
            await Slider.File.CopyToAsync(stream);
        }
        Slider newSlider = new Slider
        {
            Tittle = Slider.Tittle,
            Description = Slider.Description,
            Image = filename
        };

        await _context.Sliders.AddAsync(newSlider);
        await _context.SaveChangesAsync();

        return RedirectToAction("Index");
    }

    

}




