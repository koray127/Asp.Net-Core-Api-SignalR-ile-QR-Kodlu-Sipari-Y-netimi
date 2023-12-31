using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.Controllers
{
    public class StatisticController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
