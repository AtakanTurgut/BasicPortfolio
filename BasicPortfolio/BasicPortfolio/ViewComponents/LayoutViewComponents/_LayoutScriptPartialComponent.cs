using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents.LayoutViewComponents
{
    public class _LayoutScriptPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
