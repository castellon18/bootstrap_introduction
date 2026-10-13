using bootstrap.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace bootstrap.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult ImageHandling()
        {
            return View();
        }

        public IActionResult Colors()
        {
            return View();
        }

        public IActionResult Tables()
        {
            return View();
        }

        public IActionResult Videos()
        {
            return View();
        }

        public IActionResult Sizes()
        {
            return View();
        }

        public IActionResult Spaces()
        {
            return View();
        }

        public IActionResult Texts()
        {
            return View();
        }

        public IActionResult Forms()
        {
            return View();
        }

        public IActionResult Accordion()
        {
            return View();
        }

        public IActionResult Alerts()
        {
            return View();
        }

        public IActionResult Carousel()
        {
            return View();
        }

        public IActionResult Modals()
        {
            return View();
        }

        public IActionResult Tabs()
        {
            return View();
        }

        public IActionResult Offcanvas()
        {
            return View();
        }

        public IActionResult Toasts()
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
