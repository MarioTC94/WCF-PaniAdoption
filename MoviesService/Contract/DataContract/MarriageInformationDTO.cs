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
		public PersonDTO Mother { get; set; }

		[DataMember]
		public PersonDTO Father { get; set; }

		[DataMember]
		public int MaritalStateId { get; set; }

		[DataMember]
		public int RoomHouseId  { get; set; }

		[DataMember]
		public DateTime MarriageDate { get; set; }
	}
}