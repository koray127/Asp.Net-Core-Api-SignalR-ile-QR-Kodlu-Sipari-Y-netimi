using Microsoft.AspNetCore.Mvc;

namespace SignalRWebUl.ViewComponents.UlLayoutComponents
{
    public class _UILayoutScriptComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();  
        }
    }
}
