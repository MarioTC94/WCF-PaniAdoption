using System.Collections.Generic;
using Adoption.Contract.DataContract;
using Adoption.Core.Interface;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "WorkerTypeServices" en el código, en svc y en el archivo de configuración a la vez.
	// NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione WorkerTypeServices.svc o WorkerTypeServices.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class WorkerTypeServices : IWorkerTypeServices
	{
		private readonly IUnitOfWork uow;

		public WorkerTypeServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}
		public IEnumerable<KeyValuePairDTO> GetWorkerTypes()
		{
			var WorkerType = this.uow.WorkerType.GetAll();
			return AutoMapper.Mapper.Map<IEnumerable<KeyValuePairDTO>>(WorkerType);
		}
	}
}
