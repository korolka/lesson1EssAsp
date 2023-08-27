using homeworkLesson1Asp.NetCoreEss.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace homeworkLesson1Asp.NetCoreEss.Controllers
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
            OperatingSystem system = Environment.OSVersion;
            string message = system.VersionString;// Platform.ToString();
            ViewBag.Message = message;
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