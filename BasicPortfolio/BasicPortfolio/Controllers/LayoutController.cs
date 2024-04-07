using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.Controllers
{
    public class LayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
