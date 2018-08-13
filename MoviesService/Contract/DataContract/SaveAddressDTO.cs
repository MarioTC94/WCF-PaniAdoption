﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class SaveAddressDTO
	{
		[DataMember]
		public int ProvinceId { get; set; }

		[DataMember]
		public int CountyId { get; set; }

		[DataMember]
		public int DistrictId { get; set; }

		[DataMember]
		public string Description { get; set; }
	}
}