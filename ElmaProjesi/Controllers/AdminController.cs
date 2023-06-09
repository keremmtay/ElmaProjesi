using Microsoft.AspNetCore.Mvc;

namespace ElmaProjesi.WebUI.Controllers
{
    public class AdminController : Controller
    {
        public IActionResult Admin()
        {
            return View();
        }
        public IActionResult AdminCategoryList()
        {
            return View();
        }
    }
}
