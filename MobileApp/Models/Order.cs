using System.Collections.Generic;

namespace MobileApp.Models
{
   public class Order 
   {
        public string Id { get; set; }
		public List<Item> Items { get; set; }
		public string Status { get; set; }
		public string CreatedAt { get; set; }
	}

	public class Item
	{
	  public string Name { get; set; }
	  public int Quantity { get; set; }

	}
}