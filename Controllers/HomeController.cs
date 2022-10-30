using Flower_site.DAL;
using FlowerSite.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace FlowerSite.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _dbContext;

        public HomeController(AppDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IActionResult Index()
        {
            var sliderImgs = _dbContext.SliderImgs.ToList();
            var slider = _dbContext.Sliders.ToList();
            var category = _dbContext.Categories.ToList();
            var product = _dbContext.Products.ToList();

            var homeViewModel = new HomeViewModel
            {
                Slider = slider,
                SliderImgs = sliderImgs,
                Categories = category,
                Products = product,
            };

           
            return View(homeViewModel);
        }
    }
}
