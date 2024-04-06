using Microsoft.AspNetCore.Mvc;
using Repositories.Context;

namespace BasicPortfolio.ViewComponents
{
    public class _AboutPartialComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Abouts.ToList();

            return View(values);
        }
    }
}
