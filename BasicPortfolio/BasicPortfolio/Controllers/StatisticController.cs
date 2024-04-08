using Microsoft.AspNetCore.Mvc;
using Repositories.Context;

namespace BasicPortfolio.Controllers
{
    public class StatisticController : Controller
    {
        PortfolioContext context = new PortfolioContext();

        public IActionResult Index()
        {
            ViewBag.Skills = context.Skills.Count();
            ViewBag.Messages = context.Messages.Count();
            ViewBag.PassiveMessages = context.Messages.Where(x => x.IsRead == false).Count();
            ViewBag.ActiveMessages = context.Messages.Where(x => x.IsRead == true).Count();

			return View();
        }
    }
}
