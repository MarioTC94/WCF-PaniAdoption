using Adoption.Core.Interface;
using Adoption.Persistence;
using Adoption.Persistence.Repository;
using System;

namespace Adoption.Persistence.Repository
{
	public class UnitOfWork : IUnitOfWork
    {
        private readonly AdoptionContext context;

		public IPersonRepository Person { get; private set; }
		public IPersonTypeRepository PersonType { get; private set; }
		public IAddressRepository Address { get; private set; }
		public IProvinceRepository Province { get; private set; }
		public ICountyRepository County { get; private set; }
		public IDistrictRepository District { get; private set; }
		public IJobInformationRepository JobInformation { get; private set; }
		public IStateFileRepository StateFile { get; private set; }
		public IRoomHouseRepository RoomHouse { get; private set; }
		public IWorkerTypeRepository WorkerType { get ; private set; }
		public IMarriageInformationRepository MarriageInformation { get; private set; }
		public IMaritalStateRepository MaritalState { get; private set; }
		public IAdoptionProcessRepository AdoptionProcess { get; private set; }


		public UnitOfWork(AdoptionContext context)
        {
            Person = new PersonRepository(context);
		    PersonType = new PersonTypeRepository(context);
			Address = new AddressRepository(context);
			Province = new ProvinceRepository(context);
			County = new CountyRepository(context);
			District = new DistrictRepository(context);
			JobInformation = new JobInformationRepository(context);
			StateFile = new StateFileRepository(context);
			RoomHouse = new RoomHouseRepository(context);
			WorkerType = new WorkerTypeRepository(context);
			MarriageInformation = new MarriageInformationRepository(context);
			MaritalState = new MaritalStateRepository(context);
			AdoptionProcess = new AdoptionProcessRepository(context);



            this.context = context;
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposing || context is null)
            {
                return;
            }

            this.context.Dispose();

        }

        public int SaveChanges()
        {
            return context.SaveChanges();
        }
    }
}