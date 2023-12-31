using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUl.Dtos.DiscountDtos;

namespace SignalRWebUl.ViewComponents.DefaultComponents
{
    public class _DefaultOfferComponentPartial : ViewComponent
    {
		private IHttpClientFactory _httpClientFactory;

		public _DefaultOfferComponentPartial(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IViewComponentResult> InvokeAsync()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Discount");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultDiscountDto>>(jsonData);
				return View(values);
			}

			return View();
		}
	}
}
