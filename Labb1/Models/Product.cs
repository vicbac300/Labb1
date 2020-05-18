using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Models
{
	public class Product : A
	{
		private int ID { get; set; } = 10;
		public object CacheID { get { return ID; } }
	}

	interface A
	{
		object CacheID { get; }
	}
}
