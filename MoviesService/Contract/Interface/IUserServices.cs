using Adoption.Contract.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Web;

namespace Adoption.Contract.Interface
{
	[ServiceContract]
	public interface IUserServices
	{
		[OperationContract]
		UserDTO Register(UserDTO user);

		[OperationContract]
		UserDTO Login(string email, string password);
	}
}