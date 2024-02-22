using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public PartialViewResult NewSidebar()
        {
            return PartialView();
        }
    }
}
