using Microsoft.AspNetCore.Mvc;

namespace MvcMovies.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
