using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
