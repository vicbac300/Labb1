using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Labb1.Models;

namespace Labb1.Services
{
	public interface IProductService
	{
		Product GetByID(int id);
		IEnumerable<Product> GetAll();
	}
}
