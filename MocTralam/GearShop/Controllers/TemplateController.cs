using Microsoft.AspNetCore.Mvc;

namespace GearShop.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
