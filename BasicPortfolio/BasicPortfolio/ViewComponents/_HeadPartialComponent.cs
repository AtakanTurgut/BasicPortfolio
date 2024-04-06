using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents
{
    public class _HeadPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
