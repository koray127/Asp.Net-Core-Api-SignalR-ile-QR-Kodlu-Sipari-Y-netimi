using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.Controllers
{
    public class AdminLayoutController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
