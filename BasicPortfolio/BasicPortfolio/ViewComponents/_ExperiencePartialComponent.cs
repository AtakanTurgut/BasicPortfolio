using Microsoft.AspNetCore.Mvc;
using Repositories.Context;

namespace BasicPortfolio.ViewComponents
{
    public class _ExperiencePartialComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke() 
        {
            var values = context.Experiences.ToList();

            return View(values); 
        }
    }
}
