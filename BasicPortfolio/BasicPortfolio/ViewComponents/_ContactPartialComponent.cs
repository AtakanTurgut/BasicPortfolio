using Microsoft.AspNetCore.Mvc;

namespace BasicPortfolio.ViewComponents
{
    public class _ContactPartialComponent : ViewComponent
    {
        public IViewComponentResult Invoke() 
        {
            return View(); 
        }
    }
}
