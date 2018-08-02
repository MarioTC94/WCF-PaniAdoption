using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Adoption.Core.Models
{
	public class District
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public County County { get; set; }
		public int CountyId { get; set; }
	}
}