using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents
{
    public class _PortfolioPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
