using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutFooterPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
