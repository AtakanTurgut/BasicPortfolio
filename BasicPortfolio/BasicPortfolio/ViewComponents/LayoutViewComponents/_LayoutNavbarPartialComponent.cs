using Microsoft.AspNetCore.Mvc;
using Repositories.Context;

namespace BasicPortfolio.ViewComponents.LayoutViewComponents
{
	public class _LayoutNavbarPartialComponent : ViewComponent
	{
		PortfolioContext context = new PortfolioContext();

		public IViewComponentResult Invoke()
		{
			ViewBag.ToDoListFalseCount = context.ToDoLists.Where(x => x.Status == false).Count();

            var values = context.ToDoLists.Where(x => x.Status == false).ToList();

			return View(values);
		}
	}
}
