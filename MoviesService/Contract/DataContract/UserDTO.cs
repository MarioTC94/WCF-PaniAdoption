using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Web;

namespace Adoption.Contract.DataContract
{
	[DataContract]
	public class UserDTO
	{
		[DataMember]
		public string Email { get; set; }

		[DataMember]
		public string Name { get; set; }

		[DataMember]
		public string FirstLastName { get; set; }

		[DataMember]
		public string SecondLastName { get; set; }

		[DataMember]
		public string Password { get; set; }

	}
}