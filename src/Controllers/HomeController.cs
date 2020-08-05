using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.FileProviders;
using Microsoft.Extensions.Logging;
using SixLabors.ImageSharp;
using SixLabors.ImageSharp.PixelFormats;

namespace ImageSky5th.Controllers
{
    public class HomeController : Controller
    {
        private readonly IWebHostEnvironment env;
        private readonly ILogger<HomeController> _logger;

        public HomeController(IWebHostEnvironment env, ILogger<HomeController> logger)
        {
            this.env = env;
            _logger = logger;
        }

        public async Task<IActionResult> Index()
        {
            var image = await Image.LoadAsync<Rgb24>($@"{this.env.WebRootPath}\pixel50.png");

            return View(image);
        }
    }
}
