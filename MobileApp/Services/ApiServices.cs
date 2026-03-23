using MobileApp.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MobileApp.Services
{
	public class ApiService
	{
       public async Task<List<Order>> GetOrders()
	   {
			await Task.Delay(500);

			return new List<Order>
			{
			  new Order
			  {
				Id = "1",
				Status = "pending",
				CreatedAt = "2026-03-23",
				Items = new List<Item>
				{
				  new Item { Name = "Latte", Quantity = 2},
				  new Item { Name = "Matcha", Quantity = 1},
				}
			  }
			};
	   }
	}
}
