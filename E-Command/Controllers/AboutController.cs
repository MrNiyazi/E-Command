using Microsoft.AspNetCore.Mvc;
using E_Command.Models.Class;

namespace E_Command.Controllers
{
	public class AboutController : Controller
	{
		Context c = new Context();
		public IActionResult Index()
		{
			var value = c.Abouts.ToList();
			return View(value);
		}
	}
}
