using Microsoft.AspNetCore.Mvc;

namespace ElmaProjesi.WebUI.Controllers
{
	public class CategoryController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
