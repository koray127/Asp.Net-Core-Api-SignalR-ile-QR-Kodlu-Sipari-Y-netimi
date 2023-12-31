using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.ViewComponents.UlLayoutComponents
{
    public class _UlLayoutHeadComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
