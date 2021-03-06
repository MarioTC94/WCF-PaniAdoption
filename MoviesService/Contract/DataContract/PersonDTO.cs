﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class PersonDTO
	{
		public PersonDTO()
		{
			this.JobInformation = new Collection<JobInformationDTO>();
		}

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
		public KeyValuePairDTO PersonType { get; set; }

		[DataMember]
		public ICollection<JobInformationDTO> JobInformation { get; set; }
	}
}