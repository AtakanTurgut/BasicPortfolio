using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
