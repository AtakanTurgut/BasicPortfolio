using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutSidebarPartialComponent : ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			return View();
		}
	}
}
