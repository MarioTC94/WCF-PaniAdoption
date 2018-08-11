using Adoption.Contract.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IAddressServices" en el código y en el archivo de configuración a la vez.
	[ServiceContract]
	public interface IAddressServices
	{
		[OperationContract]
		IEnumerable<ProvinceDTO> GetProvince();

	}
}
