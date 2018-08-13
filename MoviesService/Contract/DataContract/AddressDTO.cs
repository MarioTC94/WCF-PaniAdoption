using System.Runtime.Serialization;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class AddressDTO
	{
		[DataMember]
		public KeyValuePairDTO Province { get; set; }

		[DataMember]
		public KeyValuePairDTO County { get; set; }

		[DataMember]
		public KeyValuePairDTO District { get; set; }

		[DataMember]
		public string Description { get; set; }
	}
}