using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class AdoptionRequestDTO
	{

		[DataMember]
		public MarriageInformationDTO MarriageInformation { get; set; }

		[DataMember]
		public string ProcessDescripction { get; set; }

		[DataMember]
		public bool AllDocuments { get; set; }

		[DataMember]
		public bool ParentsInterview { get; set; }

		[DataMember]
		public bool FamilyVisit { get; set; }

		[DataMember]
		public string IDKid { get; set; }

		[DataMember]
		public int StateFileId { get; set; }
	}
}