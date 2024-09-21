using Microsoft.AspNetCore.Mvc;
using P50_3.Models;
using System.Diagnostics;

namespace P50_3.Controllers
{
    public class HomeController : Controller
    {
        public HomeController()
        {
        }

        public IActionResult Catalog() 
        {
            return View();
        }

        public IActionResult Index()
        {
            ViewData["Name"] = "Андрей";
            ViewData["Age"] = 12;
            ViewData["Array"] = new List<string>();
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        private string Some()
        {
            return "Hello";
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}