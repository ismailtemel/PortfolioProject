using Microsoft.AspNetCore.Mvc;

namespace PortfolioProject.UI.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
