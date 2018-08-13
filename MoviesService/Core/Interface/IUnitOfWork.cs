using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adoption.Core.Interface
{
    public interface IUnitOfWork : IDisposable
    {
		IPersonRepository Person { get;}
		IPersonTypeRepository PersonType { get; }
		IAddressRepository Address { get; }
		IProvinceRepository Province { get; }
		ICountyRepository County { get; }
		IDistrictRepository District { get; }
		IJobInformationRepository JobInformation { get; }
		IStateFileRepository StateFile { get; }
		IRoomHouseRepository RoomHouse { get; }
		IWorkerTypeRepository WorkerType { get; }
		IMarriageInformationRepository MarriageInformation { get; }
		IMaritalStateRepository MaritalState { get;  }
		IAdoptionProcessRepository AdoptionProcess { get; }
		IUserRepository User { get; }
		int SaveChanges();
    }
}
