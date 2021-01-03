using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using web.Models;
using System.Text;
using System.Xml.Linq;

namespace web.Controllers
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

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult Exhibits()
        {
            return View();
        }

        public IActionResult Music()
        {
            return View();
        }

        public IActionResult News()
        {
            return View();
        }

        [Route("sitemap.xml")]
        public IActionResult SiteMap()
        {
            var xml = XDocument.Load("sitemap.xml");
            return Content(xml.ToString(), "xml", Encoding.UTF8);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
