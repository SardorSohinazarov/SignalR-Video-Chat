using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using VideoChat.Models;

namespace VideoChat.Controllers
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
            return Redirect($"/{Guid.NewGuid()}");
        }

        [HttpGet("/{roomId}")]
        public IActionResult Room(string roomId)
        {
            ViewBag.RoomId = roomId;
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
