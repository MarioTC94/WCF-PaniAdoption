using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class SavePersonDTO
	{

		[DataMember]
		public string Id { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string LastName { get; set; }

		[DataMember]
		public string SecondLastName { get; set; }

		[DataMember]
		public DateTime BirthDay { get; set; }

		[DataMember]
		public string Email { get; set; }

		[DataMember]
		public string Phone { get; set; }

		[DataMember]
		public int PersonTypeId { get; set; }

		[DataMember]
		public SaveJobInformationDTO JobInformation { get; set; }

	}
}