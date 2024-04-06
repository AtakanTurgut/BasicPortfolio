using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents
{
    public class _StatisticPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
