using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using Adoption.Contract.DataContract;
using Adoption.Core.Interface;
using AutoMapper;

namespace Adoption.Contract
{
	// NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "AddressServices" en el código, en svc y en el archivo de configuración a la vez.
	// NOTA: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione AddressServices.svc o AddressServices.svc.cs en el Explorador de soluciones e inicie la depuración.
	public class AddressServices : IAddressServices
	{
		private readonly IUnitOfWork uow;

		public AddressServices(IUnitOfWork uow)
		{
			this.uow = uow;
		}

		public IEnumerable<ProvinceDTO> GetProvince()
		{
			var provinces = uow.Province.GetProvinceWithRelatives();
			return Mapper.Map<IEnumerable<ProvinceDTO>>(provinces);
		}
	}
}
