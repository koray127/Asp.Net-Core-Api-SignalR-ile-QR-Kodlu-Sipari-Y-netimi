using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUl.Dtos.ContactDtos;

namespace SignalRWebUl.ViewComponents.UlLayoutComponents
{
    public class _UILayoutFooterComponentPartial : ViewComponent
    {
		private IHttpClientFactory _httpClientFactory;

		public _UILayoutFooterComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Contact");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultContactDto>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
