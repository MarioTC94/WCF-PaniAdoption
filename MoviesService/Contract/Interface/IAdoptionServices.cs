using Adoption.Contract;
using Adoption.Contract.DataContract;
using Adoption.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adoption.Contract
{
    [ServiceContract]
    public interface IAdoptionServices
    {
		[OperationContract]
		AdoptionRequestDTO AddAdoptionProcess(SaveAdoptionRequestDTO adoptionRequest);

		[OperationContract]
		int RemoveAdoptionProcess(int id);

		[OperationContract]
		AdoptionRequestDTO UpdateAdoptionProcess(int id, SaveAdoptionRequestDTO adoptionRequest);

		[OperationContract]
		AdoptionRequestDTO GetadoptionProcess(int id);
		[OperationContract]
		ICollection<AdoptionRequestDTO> GetAllAdoptionProcess();
	}
}
