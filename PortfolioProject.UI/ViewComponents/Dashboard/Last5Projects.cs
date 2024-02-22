using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.ViewComponents.Dashboard
{
    public class Last5Projects:ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
