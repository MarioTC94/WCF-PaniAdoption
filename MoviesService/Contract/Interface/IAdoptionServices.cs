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
		AdoptionProcess AddAdoptionProcess(AdoptionRequestDTO adoptionRequest);

		[OperationContract]
		void RemoveAdoptionProcess(int id);

		[OperationContract]
		void UptadeAdoptionProcess(int id, AdoptionRequestDTO adoptionRequest);

		[OperationContract]
		AdoptionProcess TryMapping();
    }
}
