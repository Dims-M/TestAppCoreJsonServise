using System;
using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using CurrencyApp.Models;
using Microsoft.Extensions.Caching.Memory;

namespace CurrencyApp.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMemoryCache memoryCache;
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger, IMemoryCache memoryCache)
        {
            _logger = logger;
            this.memoryCache = memoryCache;
        }

        public IActionResult Index()
        {
            if (!memoryCache.TryGetValue("key_currency", out CurrencyConverter model))
            {
                throw new Exception("Ошибка получения данных");
            }
            return View(model);
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
