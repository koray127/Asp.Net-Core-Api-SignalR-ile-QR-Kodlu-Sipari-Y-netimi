using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.ViewComponents.UlLayoutComponents
{
    public class _UILayoutNavbarComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
