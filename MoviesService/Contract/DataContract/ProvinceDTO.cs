using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class ProvinceDTO : KeyValuePairDTO
	{
		public ProvinceDTO()
		{
			Counties = new Collection<CountyDTO>();
		}

		[DataMember]
		public ICollection<CountyDTO> Counties { get; set; }
	}
}