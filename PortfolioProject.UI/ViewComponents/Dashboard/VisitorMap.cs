using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.ViewComponents.Dashboard
{
    public class VisitorMap : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
