using Microsoft.AspNetCore.Mvc;

namespace Ders_Agalarla.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
