using Microsoft.AspNetCore.Mvc;

namespace SeriesEFilmes.Controllers
{
    public class HelloWorldController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
