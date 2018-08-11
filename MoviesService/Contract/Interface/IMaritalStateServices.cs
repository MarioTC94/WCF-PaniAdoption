using Adoption.Contract.DataContract;
using System.Collections.Generic;
using System.ServiceModel;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IMaritalStateServices" en el código y en el archivo de configuración a la vez.
	[ServiceContract]
	public interface IMaritalStateServices
	{
		[OperationContract]
		IEnumerable<KeyValuePairDTO> GetMaritalStates();
	}
}
