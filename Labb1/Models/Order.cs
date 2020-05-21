using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
	public class Order
	{
		public int ID { get; set; }
		public DateTime Date { get; set; }
		public int UserID { get; set; }
		public List<OrderRow> OrderRows { get; set; }
		public decimal TotalPrice { get; set; }
	}

	public class OrderRow
	{
		public Product Product { get; set; }
		public int Amount { get; set; }
	}
}
