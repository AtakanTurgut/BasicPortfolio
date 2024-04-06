using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents
{
    public class _TestimonialPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
