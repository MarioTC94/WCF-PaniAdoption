
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class MarriageInformationDTO
	{
		[DataMember]
		public int Id { get; set; }

		[DataMember]
		public PersonDTO Mother { get; set; }

		[DataMember]
		public PersonDTO Father { get; set; }

		[DataMember]
		public KeyValuePairDTO MaritalState { get; set; }

		[DataMember]
		public KeyValuePairDTO RoomHouse { get; set; }

		[DataMember]
		public DateTime MarriageDate { get; set; }

		[DataMember]
		public AddressDTO Address { get; set; }

	}
}