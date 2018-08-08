using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adoption.Core.Models
{
	public class Address{

		public int Id { get; set; }

		public int ProvinceId { get; set; }

		public int CountyId { get; set; }

		public int DistrictId { get; set; }

		[Required]
		[StringLength(300)]
		public string AddressDescription { get; set; }

		[Required]
		public string PersonId { get; set; }

		public Province Province { get; set; }
		public County County { get; set; }
		public District District { get; set; }

		public Person Person { get; set; }
	}
}