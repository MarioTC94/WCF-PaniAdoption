using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class JobInformationDTO
	{
		[DataMember]
		public string CompanyName { get; set; }

		[DataMember]
		public string ActualPosition { get; set; }

		[DataMember]
		public Decimal AnualSalary { get; set; }

		[DataMember]
		public string Phone { get; set; }

		[DataMember]
		public string AddressCompany { get; set; }

		[DataMember]

		public int WorkerTypeId { get; set; }

	}
}