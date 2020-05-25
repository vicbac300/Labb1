using System;
using System.Collections.Generic;
using System.Linq;
using Labb1.Models;
using System.Threading.Tasks;

namespace Labb1.ViewModels
{
	public class CartViewModel
	{
		public long CreatedTicks { get; set; }
		public List<CartItem> Products { get; set; }
		public decimal TotalPrice { get; set; }
		public decimal Test { get; set; }

		public CartViewModel()
		{
			
		}
	}

	public class CartItem
	{
		public Product Product { get; set; }
		public int Amount { get; set; }
	}
}
