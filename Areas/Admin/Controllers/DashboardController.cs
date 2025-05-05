using Microsoft.AspNetCore.Mvc;

namespace Pronio.Areas.Admin.Controllers
{
    public class DashboardController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
