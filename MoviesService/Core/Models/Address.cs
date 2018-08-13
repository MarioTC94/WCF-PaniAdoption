using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace Adoption.Core.Models
{
	public class Address{

		public int Id { get; set; }


		[Required]
		public int ProvinceId { get; set; }
		public Province Province { get; set; }

		[Required]
		public int CountyId { get; set; }
		public County County { get; set; }

		[Required]
		public int DistrictId { get; set; }
		public District District { get; set; }

		[Required]
		[StringLength(300)]
		public string AddressDescription { get; set; }

		[Required]
		public int MarriageInformationId { get; set; }

		public MarriageInformation MarriageInformation { get; set; }
	}
}