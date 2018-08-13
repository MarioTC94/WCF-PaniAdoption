using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Runtime.Serialization;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class CountyDTO : KeyValuePairDTO
	{
		public CountyDTO()
		{
			Districts = new Collection<KeyValuePairDTO>();
		}

		[DataMember]
		public ICollection<KeyValuePairDTO> Districts { get; set; }
	}

}