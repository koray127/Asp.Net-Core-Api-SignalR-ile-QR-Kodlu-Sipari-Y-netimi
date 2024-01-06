using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SignalRWebUl.Dtos.BasketDtos;
using System.Text;

namespace SignalRWebUl.Controllers
{
	public class BasketsController : Controller
	{
		private IHttpClientFactory _httpClientFactory;

		public BasketsController(IHttpClientFactory httpClientFactory)
		{
			_httpClientFactory = httpClientFactory;
		}

		public async Task<IActionResult> Index()
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.GetAsync("https://localhost:7217/api/Basket/BasketListByMenuTableWithProductName?id=6");
			if (responseMessage.IsSuccessStatusCode)
			{
				var jsonData = await responseMessage.Content.ReadAsStringAsync();
				var values = JsonConvert.DeserializeObject<List<ResultBasketDto>>(jsonData);
				return View(values);
			}

			return View();
		}
		public async Task<IActionResult> DeleteBasket(int id)
		{
			var client = _httpClientFactory.CreateClient();
			var responseMessage = await client.DeleteAsync($"https://localhost:7217/api/Basket/{id}");
			if (responseMessage.IsSuccessStatusCode)
			{
				return RedirectToAction("Index");
			}
			return NoContent();
		}
	}
}
