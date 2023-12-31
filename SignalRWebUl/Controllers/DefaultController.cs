using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.Controllers
{
	public class DefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
	}
}
