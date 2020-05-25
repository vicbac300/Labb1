using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb1.Models;
using Labb1.ViewModels;

namespace Labb1
{
	public static class Util
	{
		public static OrderRow ToOrderRow(this CartItem cartItem)
		{
			return new OrderRow()
			{
				Product = cartItem.Product,
				Amount = cartItem.Amount
			};
		}

		public static List<OrderRow> ToOrderRowList(this IEnumerable<CartItem> cartItems)
		{
			var l = new List<OrderRow>();
			foreach (var item in cartItems)
			{
				l.Add(item.ToOrderRow());
			}

			return l;
		}
	}
}
