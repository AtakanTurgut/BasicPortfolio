using Microsoft.AspNetCore.Mvc;
using Repositories.Context;

namespace BasicPortfolio.ViewComponents
{
    public class _SkillPartialComponent : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();

        public IViewComponentResult Invoke() 
        {
            var values = context.Skills.ToList();

            return View(values); 
        }
    }
}
