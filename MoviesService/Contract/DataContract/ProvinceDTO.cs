using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;

namespace Adoption.Contract.DataContract
{
	public class ProvinceDTO : KeyValuePairDTO
	{
		public ProvinceDTO()
		{
			Counties = new Collection<CountyDTO>();
		}
		public ICollection<CountyDTO> Counties { get; set; }
	}
}