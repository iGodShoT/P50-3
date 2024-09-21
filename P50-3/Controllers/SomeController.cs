using Microsoft.AspNetCore.Mvc;

namespace P50_3.Controllers
{
    public class SomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
