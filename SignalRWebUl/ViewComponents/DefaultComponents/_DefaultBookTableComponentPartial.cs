using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.ViewComponents.DefaultComponents
{
    public class _DefaultBookTableComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}
