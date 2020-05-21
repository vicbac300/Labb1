using Labb1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Labb1.Services
{
	public class MockProductService : IProductService
	{
		private Dictionary<int, Product> products = new Dictionary<int, Product>();

		public MockProductService()
		{
			for (int i = 0; i < 10; i++)
			{
				int id = i + 1;
				Product p = new Product()
				{
					ID = id,
					Name = "Produkt " + id,
					Price = 100m + i
				};
				products.Add(id, p);
			}
		}

		public IEnumerable<Product> GetAll()
		{
			return products.Values;
		}

		public Product GetByID(int id)
		{
			return products[id];
		}
	}
}
