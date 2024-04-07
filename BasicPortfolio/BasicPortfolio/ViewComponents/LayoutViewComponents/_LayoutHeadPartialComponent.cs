using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutHeadPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
