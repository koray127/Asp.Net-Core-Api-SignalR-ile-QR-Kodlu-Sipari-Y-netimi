using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.Controllers
{
	public class UILayoutController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
