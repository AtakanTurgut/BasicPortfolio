using Microsoft.AspNetCore.Mvc;
using Repositories.Context;

namespace BasicPortfolio.ViewComponents
{
    public class _FeaturePartialComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var values = context.Features.ToList();

            return View(values);
        }
    }
}
