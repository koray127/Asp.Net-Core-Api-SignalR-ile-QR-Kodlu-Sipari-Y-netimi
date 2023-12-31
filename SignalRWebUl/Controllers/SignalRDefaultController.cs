using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.Controllers
{
	public class SignalRDefaultController : Controller
	{
		public IActionResult Index()
		{
			return View();
		}
		public IActionResult Index2()
		{
			return View();
		}
	}
}
