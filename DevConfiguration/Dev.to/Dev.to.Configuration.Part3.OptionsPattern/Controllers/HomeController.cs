using Dev.to.Configuration.Part3.OptionsPattern.Config;
using Dev.to.Configuration.Part3.OptionsPattern.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace Dev.to.Configuration.Part3.OptionsPattern.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly MustafaConfiguration _mustafaConfiguration;
        public HomeController(ILogger<HomeController> logger, IOptions<MustafaConfiguration> mustafaConfiguration)
        {
            _logger = logger;
            _mustafaConfiguration = mustafaConfiguration.Value;
        }

        public IActionResult Index()
        {
            ViewBag.Soyad = _mustafaConfiguration.Soyad;
            ViewBag.Yas = _mustafaConfiguration.Yas;
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
    }
}
