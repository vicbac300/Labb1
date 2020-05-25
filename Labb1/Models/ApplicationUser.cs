using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
namespace Labb1.Models
{
	public class ApplicationUser : IdentityUser
	{
		public string StreetAdress { get; set; }
		public string FirstName { get; set; }
		public string LastName { get; set; }

		public string PostalCode { get; set; }
		public string City { get; set; }
	}
}
