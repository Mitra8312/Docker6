using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using net.Models;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace net.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }

        [HttpGet("bind-mount")]
        public IActionResult GetImageBindMount()
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "ImagesBindMount", "1.jpg");
            return PhysicalFile(imagePath, "image/jpg");
        }

        [HttpGet("volume")]
        public IActionResult GetImageVolume()
        {
            var imagePath = Path.Combine(Directory.GetCurrentDirectory(), "ImagesVolume", "2.jpg");
            return PhysicalFile(imagePath, "image/jpg");
        }

        // Добавим метод для отображения представления с изображением
        [HttpGet("view")]
        public IActionResult GetImageView()
        {
            return View();
        }
    }
}
