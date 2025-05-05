using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

namespace Pronio.Controllers;

public class HomeController : Controller
{

    public IActionResult Index()
    {
        return View();
    }

}
