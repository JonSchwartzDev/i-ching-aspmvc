using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using i_ching_aspmvc.Models;

#nullable enable 

namespace i_ching_aspmvc.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private string currentPage = "Tao";

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Page(string pageToDisplay)
        {
            currentPage = ((pageToDisplay == null) ? "Tao" : pageToDisplay);
            var model = Pages.Page[currentPage];
            return View(model);
        }

        public IActionResult Hexagram(int upper = 0, int lower = 0)
        {
            var model = iChingModel.Hexagrams[upper, lower];
            return View(model);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
