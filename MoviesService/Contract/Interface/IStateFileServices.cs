using Adoption.Contract.DataContract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IStateFileServices" en el código y en el archivo de configuración a la vez.
	[ServiceContract]
	public interface IStateFileServices
	{
		[OperationContract]
		IEnumerable<KeyValuePairDTO> GetStateFiles();
	}
}
