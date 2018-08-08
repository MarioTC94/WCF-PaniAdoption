using System.Collections.Generic;
using System.Collections.ObjectModel;

namespace Adoption.Contract.DataContract
{
	public class CountyDTO : KeyValuePairDTO
	{

		public CountyDTO()
		{
			Districts = new Collection<KeyValuePairDTO>();
		}

		public ICollection<KeyValuePairDTO> Districts { get; set; }
	}

}