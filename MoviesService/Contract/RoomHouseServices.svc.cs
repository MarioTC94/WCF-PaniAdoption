using Adoption.Contract.DataContract;
using Adoption.Core.Interface;
using System.Collections.Generic;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "RoomHouseServices" en el código, en svc y en el archivo de configuración a la vez.
	// NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione RoomHouseServices.svc o RoomHouseServices.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class RoomHouseServices : IRoomHouseServices
	{
		private readonly IUnitOfWork uow;

		public RoomHouseServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public IEnumerable<KeyValuePairDTO> GetRoomHouses()
		{
			var roomHouse = this.uow.RoomHouse.GetAll();
			return AutoMapper.Mapper.Map<IEnumerable<KeyValuePairDTO>>(roomHouse);
		}
	}
}
