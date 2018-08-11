using Adoption.Contract.DataContract;
using Adoption.Core.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MaritalStateServices" en el código, en svc y en el archivo de configuración a la vez.
	// NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MaritalStateServices.svc o MaritalStateServices.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class MaritalStateServices : IMaritalStateServices
	{
		private readonly IUnitOfWork uow;

		public MaritalStateServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public IEnumerable<KeyValuePairDTO> GetMaritalStates()
		{
			var maritalState = this.uow.MaritalState.GetAll();
			var map = AutoMapper.Mapper.Map<IEnumerable<KeyValuePairDTO>>(maritalState);
			return map;
		}
	}
}
