using Microsoft.AspNetCore.Mvc;

namespace E_Command.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
